using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using TeleMedichineProject.Common;
using TeleMedichineProject.Models.DTO;
using TeleMedichineProject.Models.TeleClass;
using TeleMedichineProject.Services;

namespace TeleMedichineProject.Controllers
{
    public class PrescriptionController : Controller
    {
        private readonly ErcDbContext _db;
        private readonly ITariffService _tariffService;
        private readonly AppUserLogin _user;

        public PrescriptionController(ErcDbContext db, ITariffService tariffService, AppUserLogin user)
        {
            _db = db;
            _tariffService = tariffService;
            _user = user;
        }

        [HttpGet]
        public async Task<IActionResult> SearchItems(
        string term = "",
        int page = 1,
        int pageSize = 10)
            {
            var baseQuery = from i in _db.Item
                            join u in _db.ItemUnit on i.BaseUnitCode equals u.ItemUnitCode into uJoin
                            from u in uJoin.DefaultIfEmpty()
                            join inv in _db.ItemInventory on i.ItemID equals inv.ItemID into invJoin
                            from inv in invJoin.DefaultIfEmpty()
                            where !i.IsDeleted && i.IsActive && i.GCItemType == "X0001^02"
                            select new { i, u, inv };

            if (!string.IsNullOrWhiteSpace(term))
            {
                baseQuery = baseQuery.Where(x =>
                    x.i.ItemName1.Contains(term) ||
                    x.i.ShortName.Contains(term));
            }

            var totalCount = await baseQuery.CountAsync();

            var items = await baseQuery
                .OrderBy(x => x.i.ItemName1)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(x => new
                {
                    id = x.i.ItemID,
                    text = x.i.ItemName1,
                    shortName = x.i.ShortName,
                    stock = x.inv.QtyOnHand,       // sesuaikan nama field
                    unit = x.u.ItemUnitName,
                    unitCode = x.u.ItemUnitCode// sesuaikan nama field
                })
                .ToListAsync();

            return Json(new
                {
                    items,
                    totalCount
                });
            }

        [HttpGet]
        public async Task<IActionResult> GetItemUnit()
        {
            // Mengambil data dari tabel TemplateConsumeMethod
            var itemUnits = await _db.ItemUnit
                .Where(m => m.IsActive == true)
                .Select(m => new {
                    itemUnitCode = m.ItemUnitCode,
                    itemUnitName = m.ItemUnitName
                })
                .ToListAsync();
            return Json(itemUnits);
        }

        [HttpGet]
        public async Task<IActionResult> GetRoute()
        {
            // Mengambil data dari tabel TemplateConsumeMethod
            var route = await _db.sysGeneralCode
                .Where(m => m.IsActive == true && m.ParentID == "0162")
                .Select(m => new {
                    generalId = m.GeneralCodeID,
                    routeName = m.GeneralCodeName1
                })
                .ToListAsync();
            return Json(route);
        }

        [HttpGet]
        public async Task<IActionResult> GetInstruction()
        {
            // Mengambil data dari tabel TemplateConsumeMethod
            var instruc = await _db.sysGeneralCode
                .Where(m => m.IsActive == true && m.ParentID == "X0279")
                .Select(m => new {
                    generalId = m.GeneralCodeID,
                    insName = m.GeneralCodeName1
                })
                .ToListAsync();
            return Json(instruc);
        }

        [HttpGet]
        public async Task<IActionResult> GetConsumeMethods()
        {
            // Mengambil data dari tabel TemplateConsumeMethod
            var methods = await _db.TemplateConsumeMethod
                .Where(m => !m.IsDeleted)
                .Select(m => new {
                    id = m.Id,
                    ConsumeMethodName = m.ConsumeMethodName, // Misal: "3x1"
                    freq = m.Frequency,       // Nilai 3 dari "3d"
                    duration = m.Duration      // Nilai 3 dari "3x"
                })
                .ToListAsync();
            return Json(methods);
        }

        [HttpGet]
        public async Task<IActionResult> GetFrequencyTemplates()
        {
            var templates = await _db.TemplateConsumeMethod
                .Select(t => new {
                    t.Id,
                    t.ConsumeMethodName, // misal: "3x1 (3 hari)"
                    t.Frequency,     // misal: 3
                    t.Duration,
                    t.Remarks// misal: 3
                })
                .ToListAsync();
            return Json(templates);
        }

        [HttpGet]
        public async Task<IActionResult> GetSignaTemplates()
        {
            var templates = await _db.TemplateConsumeMethod
                .Select(t => new {
                    t.Id,
                    t.ConsumeMethodName, // misal: "3x1 (3 hari)"
                    t.Frequency,     // misal: 3
                    t.Duration       // misal: 3
                })
                .ToListAsync();
            return Json(templates);
        }

        [HttpGet]
        public async Task<IActionResult> GetRouteTemplates()
        {
            var templates = await _db.TemplateConsumeMethod
                .Select(t => new {
                    t.Id,
                    t.ConsumeMethodName, // misal: "3x1 (3 hari)"
                    t.Frequency,     // misal: 3
                    t.Duration       // misal: 3
                })
                .ToListAsync();
            return Json(templates);
        }

        // Request model
        public class SendToPharmacyRequest
        {
            public string RegistrationNo { get; set; }
        }

        [HttpGet]
        public async Task<IActionResult> GetPrescriptions(string registrationNo)
        {
            if (string.IsNullOrEmpty(registrationNo)) return Json(new { success = false, message = "Registration No kosong" });

            var prescriptions = await (from hd in _db.JobOrderHd
                                       join dt in _db.JobOrderDt on hd.JobOrderNo equals dt.JobOrderNo
                                       join med in _db.JobOrderDtMedication on new { dt.JobOrderNo, dt.SequenceNo } equals new { med.JobOrderNo, med.SequenceNo }
                                       join item in _db.Item on dt.ItemID equals item.ItemID
                                       join sgc in _db.sysGeneralCode on med.GCRoute equals sgc.GeneralCodeID
                                       join unit in _db.ItemUnit on item.BaseUnitCode equals unit.ItemUnitCode
                                       where hd.RegistrationNo == registrationNo && !hd.IsDeleted && !dt.IsDeleted
                                       orderby hd.JobOrderDateTime descending, dt.SequenceNo
                                       select new
                                       {
                                           jobOrderNo = hd.JobOrderNo,
                                           itemName = item.ItemName1,
                                           dose = med.Dose,
                                           frequency = med.Frequency,
                                           qty = med.DispenseQty,
                                           signa = med.GCSigna,
                                           route = sgc.GeneralCodeName1,
                                           unit = unit.ItemUnitName,
                                           remarks = med.Remarks,
                                           date = hd.JobOrderDateTime.ToString("dd MMM yyyy HH:mm")
                                       }).ToListAsync();

            return Json(new { success = true, data = prescriptions });
        }

        [HttpPost]
        public async Task<IActionResult> SavePrescription([FromBody] SavePrescriptionRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.RegistrationNo))
                return Json(new { success = false, message = "Data request tidak valid." });

            var stra = _db.Database.CreateExecutionStrategy();
            return await stra.ExecuteAsync(async () =>
            {
                using var transaction = await _db.Database.BeginTransactionAsync();
                try
                {
                    var reg = await _db.Registration
                        .FirstOrDefaultAsync(x => x.RegistrationNo == request.RegistrationNo);
                    if (reg == null)
                        return Json(new { success = false, message = "Data Registrasi tidak ditemukan." });

                    // ── CARI JobOrderHd yang masih bisa dipakai ──────────
                    var existingJoHd = await _db.JobOrderHd
                        .FirstOrDefaultAsync(x =>
                            x.RegistrationNo == request.RegistrationNo &&
                            x.JobOrderType == "Medication" &&
                            x.IsReviewed == false &&
                            x.IsDeleted == false);

                    string jobOrderNo;

                    if (existingJoHd != null)
                    {
                        // Pakai JobOrderNo yang sudah ada
                        jobOrderNo = existingJoHd.JobOrderNo;
                    }
                    else
                    {
                        // Buat JobOrderHd baru
                        var jobOrderNoResult = await _db.Database
                            .SqlQueryRaw<TransactionNumberResult>(
                                "EXEC uspTransactionNumber @SiteCode, @TransactionCode, @ServiceUnitID, @TransactionDate",
                                new SqlParameter("@SiteCode", _user.SiteCode),
                                new SqlParameter("@TransactionCode", "009"),
                                new SqlParameter("@ServiceUnitID", "OP"),
                                new SqlParameter("@TransactionDate", DateTime.Now.ToString("yyyyMMdd"))
                            ).ToListAsync();

                        jobOrderNo = jobOrderNoResult.FirstOrDefault()?.TransactionNumber;
                        if (string.IsNullOrEmpty(jobOrderNo))
                            throw new Exception("Gagal generate nomor JobOrder.");

                        var joHd = new JobOrderHd
                        {
                            JobOrderNo = jobOrderNo,
                            RegistrationNo = request.RegistrationNo,
                            JobOrderDateTime = DateTime.Now,
                            SiteCode = _user.SiteCode,
                            ServiceUnitID = reg.ServiceUnitID,
                            StartDateTime = DateTime.Now,
                            ParamedicID = request.Items.FirstOrDefault()?.ParamedicID ?? reg.ParamedicID ?? 0,
                            TransactionCode = "009",
                            JobOrderType = "Medication",
                            IsCanceled = false,
                            IsVerified = false,
                            IsReviewed = false,
                            IsDeleted = false,
                            LastUpdatedBy = _user.UserName,
                            LastUpdatedDateTime = DateTime.Now
                        };
                        _db.JobOrderHd.Add(joHd);
                    }

                    // ── CARI SequenceNo terakhir untuk JobOrderNo ini ────
                    var lastSeqStr = await _db.JobOrderDt
                        .Where(x => x.JobOrderNo == jobOrderNo && !x.IsDeleted)
                        .OrderByDescending(x => x.SequenceNo)
                        .Select(x => x.SequenceNo)
                        .FirstOrDefaultAsync();

                    int nextSeq = 1;
                    if (!string.IsNullOrEmpty(lastSeqStr) && int.TryParse(lastSeqStr, out int lastSeqInt))
                        nextSeq = lastSeqInt + 1;

                    // ── INSERT ITEM ───────────────────────────────────────
                    foreach (var item in request.Items)
                    {
                        var seqStr = nextSeq.ToString("D3");

                        // Get Tariff
                        var tariffReq = new TariffRequest
                        {
                            SiteCode = _user.SiteCode,
                            RegistrationNo = request.RegistrationNo,
                            ItemID = item.ItemID,
                            TransactionDate = DateTime.Now,
                            IsRecalculation = false,
                            ChargeClassCode = reg.ChargeClassCode,
                            CoveredClassCode = reg.CoveredClassCode,
                            BusinessPartnerID = reg.BusinessPartnerID,
                            DocumentNo = reg.CustomerDocumentNo
                        };
                        var tariff = await _tariffService.GetTariffAsync(tariffReq);

                        // Insert JobOrderDt
                        var joDt = new JobOrderDt
                        {
                            JobOrderNo = jobOrderNo,
                            SequenceNo = seqStr,
                            ItemID = item.ItemID,
                            StandartPrice = tariff.StandardPrice ?? 0,
                            CustomerPrice = tariff.CustomerPrice ?? 0,
                            PersonalPrice = tariff.PersonalPrice ?? 0,
                            DiscountPrice = tariff.DiscountPrice ?? 0,
                            IsDeleted = false,
                            LastUpdatedBy = _user.UserName,
                            LastUpdatedDateTime = DateTime.Now,
                            ToBePerformed = "Y",
                            OrderNotes = item.Remarks ?? "-"
                        };
                        _db.JobOrderDt.Add(joDt);

                        // Insert JobOrderDtMedication
                        var joMed = new JobOrderDtMedication
                        {
                            JobOrderNo = jobOrderNo,
                            SequenceNo = seqStr,
                            ItemID = item.ItemID,
                            Dose = item.Dose,
                            Frequency = (item.Frequency ?? "").Length > 5
                                                ? (item.Frequency ?? "").Substring(0, 5)
                                                : (item.Frequency ?? "-"),
                            Duration = (byte)(item.Duration > 0 ? item.Duration : 1),
                            DispenseQty = item.Qty,
                            ConsumeUnit = item.ItemUnit,
                            GCSigna = item.Signa,
                            GCRoute = item.Route,
                            Remarks = item.Remarks,
                            StartDateTime = DateTime.Now,
                            Prescriber = _user.UserName,
                            IsPrescription = true,
                            IsByDosage = false,
                            IsAutopack = false,
                            IsDeleted = false,
                            IsAdministrationHere = false,
                            IsSelectedAdministrationHere = false,
                            IsDischargePrescription = false,
                            TakenQtyDummy = 0,
                            ParamedicID = item.ParamedicID
                        };
                        _db.JobOrderDtMedication.Add(joMed);

                        nextSeq++;
                    }

                    await _db.SaveChangesAsync();
                    await transaction.CommitAsync();

                    return Json(new { success = true, jobOrderNo = jobOrderNo });
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    return Json(new { success = false, message = "Terjadi kesalahan: " + ex.Message });
                }
            });
        }
    }
}
