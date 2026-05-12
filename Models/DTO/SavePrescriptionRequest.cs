using System;
using System.Collections.Generic;

namespace TeleMedichineProject.Models.DTO
{
    public class SavePrescriptionRequest
    {
        public string RegistrationNo { get; set; } = string.Empty;
        public List<PrescriptionItemRequest> Items { get; set; } = new List<PrescriptionItemRequest>();
    }

    public class PrescriptionItemRequest
    {
        public int ItemID { get; set; }
        public decimal Dose { get; set; }
        public string? Frequency { get; set; }
        public decimal Qty { get; set; }
        public int Duration { get; set; }   // ← tambah ini
        public string? ItemUnit { get; set; } // ← tambah ini
        public string? Signa { get; set; }
        public string? Route { get; set; }
        public string? Remarks { get; set; }
        public int ParamedicID { get; set; }
    }
}
