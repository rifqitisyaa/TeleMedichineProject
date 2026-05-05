using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class PatientVision
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExaminationDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCColorBlindness { get; set; } = null!;

    public bool IsRedGreenDefect { get; set; }

    public bool IsOtherColorDefect { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? Depth { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? PerimeterScoreRight { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? PerimeterScoreLeft { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? TonometryScoreRight { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? TonometryScoreLeft { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? VisionFarRight1 { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? VisionFarLeft1 { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? VisionFarBoth1 { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? VisionNearRight1 { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? VisionNearLeft1 { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? VisionNearBoth1 { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? VisionFarRight2 { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? VisionFarLeft2 { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? VisionFarBoth2 { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? VisionNearRight2 { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? VisionNearLeft2 { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? VisionNearBoth2 { get; set; }

    public bool IsHeterophoria { get; set; }

    public bool IsHyperphoriaRight { get; set; }

    public bool IsHyperphoriaLeft { get; set; }

    public bool IsEsophoria { get; set; }

    public bool IsExophoria { get; set; }

    public bool IsInternal { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCColorBlindness")]
    [InverseProperty("PatientVision")]
    public virtual sysGeneralCode GCColorBlindnessNavigation { get; set; } = null!;

    [ForeignKey("MedicalNo")]
    [InverseProperty("PatientVision")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PatientVision")]
    public virtual Registration? RegistrationNoNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("PatientVision")]
    public virtual Site? SiteCodeNavigation { get; set; }
}
