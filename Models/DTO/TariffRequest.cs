using System;

namespace TeleMedichineProject.Models.DTO
{
    public class TariffRequest
    {
        public string RegistrationNo { get; set; } = string.Empty;
        public int ItemID { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;
        public bool IsRecalculation { get; set; }
        public string? CoveredClassCode { get; set; }
        public string? ChargeClassCode { get; set; }
        public int? BusinessPartnerID { get; set; }
        public string? DocumentNo { get; set; }
        public string SiteCode { get; set; } = string.Empty;
    }
}
