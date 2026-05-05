using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "GCRLType", "RLReportID", "Period")]
public partial class RL1CaraPembayaran
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCRLType { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string RLReportID { get; set; } = null!;

    [Key]
    [StringLength(6)]
    [Unicode(false)]
    public string Period { get; set; } = null!;

    public int JumlahKeluarRI { get; set; }

    public int LamaRawatRI { get; set; }

    public int JumlahPasienRJ { get; set; }

    public int JumlahLaboratoriumLangsung { get; set; }

    public int JumlahRadiologiLangsung { get; set; }

    public int JumlahLainLainLangsung { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PendapatanSeharusnya { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PendapatanDiterima { get; set; }

    public bool IsProceed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }

    [ForeignKey("GCRLType, RLReportID")]
    [InverseProperty("RL1CaraPembayaran")]
    public virtual RLReportTemplate RLReportTemplate { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("RL1CaraPembayaran")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
