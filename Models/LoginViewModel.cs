using System.ComponentModel.DataAnnotations;

namespace MasterPageTest.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        // =========================
        // FUTURE USE (sementara belum dipakai di View)
        // =========================

        public string? SiteCode { get; set; }

        public Guid RoleId { get; set; }

        public int ServiceUnitId { get; set; }
    }
}