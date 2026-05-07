using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeleMedichineProject.Common;
using TeleMedichineProject.Models.TeleClass;

namespace TeleMedichineProject.Controllers
{
    [Authorize]
    public class SoapController : Controller
    {
        private readonly ErcDbContext _db;
        private readonly AppUserLogin _appUserLogin;

        public SoapController(ErcDbContext db, AppUserLogin appUserLogin)
        {
            _db = db;
            _appUserLogin = appUserLogin;
        }

        public class SaveSoapRequest
        {
            public string RegistrationNo { get; set; }
            public string Subjective { get; set; }
            public string Objective { get; set; }
            public string Assessment { get; set; }
            public string Planning { get; set; }
        }

        [HttpPost]
        public async Task<IActionResult> SaveSoap([FromBody] SaveSoapRequest request)
        {
            try
            {
                var registration = await _db.Registration
                    .FirstOrDefaultAsync(r => r.RegistrationNo == request.RegistrationNo && !r.IsDeleted);

                if (registration == null)
                    return Json(new { success = false, message = "Registrasi tidak ditemukan." });

                // Generate SequenceNo
                var lastSeq = await _db.PatientNotes
                    .Where(p => p.RegistrationNo == request.RegistrationNo)
                    .OrderByDescending(p => p.SequenceNo)
                    .Select(p => p.SequenceNo)
                    .FirstOrDefaultAsync();

                var nextSeqInt = string.IsNullOrEmpty(lastSeq) ? 1 : int.Parse(lastSeq) + 1;
                var nextSeq = nextSeqInt.ToString().PadLeft(5, '0');

                var soapText = $"SUBJECTIVE : {request.Subjective}\n" +
                               $"OBJECTIVE : {request.Objective}\n" +
                               $"ASSESSMENT : {request.Assessment}\n" +
                               $"PLANNING : {request.Planning}";

                var patientNotes = new PatientNotes
                {
                    RegistrationNo = request.RegistrationNo,
                    SequenceNo = nextSeq,
                    SiteCode = _appUserLogin.SiteCode,
                    GCPatientNotesType = "X0085^003",
                    NotesDateTime = DateTime.Now,
                    ParamedicID = _appUserLogin.ParamedicId,
                    Notes = soapText,
                    IsDeleted = false,
                    LastUpdatedBy = _appUserLogin.UserName,
                    LastUpdatedDateTime = DateTime.Now
                };

                _db.PatientNotes.Add(patientNotes);

                if (registration.PresentIllnessNotes == null)
                {
                    registration.PresentIllnessNotes = soapText;
                    registration.LastUpdatedBy = _appUserLogin.UserName;
                    registration.LastUpdatedDateTime = DateTime.Now;
                }

                await _db.SaveChangesAsync();

                return Json(new { success = true, message = "SOAP berhasil disimpan." });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Terjadi kesalahan: " + ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetSoapHistory(string medicalNo)
        {
            var notes = await _db.PatientNotes
                .Join(_db.Registration,
                    note => note.RegistrationNo,         
                    reg => reg.RegistrationNo,                       
                    (note, reg) => new { note, reg })
                .Join(_db.Paramedic,
                notep => notep.note.ParamedicID,
                par => par.ParamedicID,
                (nr,par) => new {nr.note,nr.reg,par})
                .Where(x => x.reg.MedicalNo == medicalNo
                         && !x.reg.IsDeleted
                         && x.note.GCPatientNotesType == "X0085^003")
                .OrderByDescending(x => x.note.NotesDateTime)
                .Select(x => new {
                    x.note.SequenceNo,
                    x.note.Notes,
                    x.note.NotesDateTime,
                    x.note.ParamedicID,
                    x.par.ParamedicName
                })
                .ToListAsync();

            return Json(new { success = true, data = notes });
        }
    }
}