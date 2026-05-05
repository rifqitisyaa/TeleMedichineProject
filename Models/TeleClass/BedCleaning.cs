using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class BedCleaning
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string CleaningNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CleaningDateTime { get; set; }

    public int BedID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    public bool? IsStart { get; set; }

    public bool? IsFinish { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FinishDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCCleaningMethod { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TakenBy { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? InspectBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InspectDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCResult { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? InspectRemarks { get; set; }

    public bool? IsCleaned { get; set; }

    public bool? IsInspected { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BedID")]
    [InverseProperty("BedCleaning")]
    public virtual Bed Bed { get; set; } = null!;

    [ForeignKey("GCCleaningMethod")]
    [InverseProperty("BedCleaningGCCleaningMethodNavigation")]
    public virtual sysGeneralCode? GCCleaningMethodNavigation { get; set; }

    [ForeignKey("GCResult")]
    [InverseProperty("BedCleaningGCResultNavigation")]
    public virtual sysGeneralCode? GCResultNavigation { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("BedCleaning")]
    public virtual Patient? MedicalNoNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("BedCleaning")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("BedCleaning")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
