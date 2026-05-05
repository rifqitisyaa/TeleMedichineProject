using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ForecastHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ForecastNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ForecastDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    public int ForecastYear { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public int? SiteDepartmentID { get; set; }

    public int? ServiceUnitID { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? ForecastQty { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    public bool IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("ForecastNoNavigation")]
    public virtual ICollection<ForecastSubDt> ForecastSubDt { get; set; } = new List<ForecastSubDt>();

    [ForeignKey("ForecastYear")]
    [InverseProperty("ForecastHd")]
    public virtual FiscalPeriodHd ForecastYearNavigation { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("ForecastHd")]
    public virtual DepartmentServiceUnit? ServiceUnit { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("ForecastHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("SiteDepartmentID")]
    [InverseProperty("ForecastHd")]
    public virtual SiteDepartment? SiteDepartment { get; set; }

    [ForeignKey("TransactionCode")]
    [InverseProperty("ForecastHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
