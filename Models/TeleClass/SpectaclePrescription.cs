using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SequenceNo", "RegistrationNo")]
public partial class SpectaclePrescription
{
    [Key]
    [StringLength(6)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Unicode(false)]
    public string? NamaDokter { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Tanggal { get; set; }

    public bool? Trifocus { get; set; }

    public bool? Bifocus { get; set; }

    public bool? SingleFocus { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Pro { get; set; }

    public int? Umur { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LeftDistantSphere { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LeftDistantCylinder { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LeftDistantAxis { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LeftDistantPrism { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LeftNearSphere { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LeftNearCylinder { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LeftNearAxis { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LeftNearPrism { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LeftBase { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LeftAdd { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RightDistantSphere { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RightDistantCylinder { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RightDistantAxis { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RightDistantPrism { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RightNearSphere { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RightNearCylinder { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RightNearAxis { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RightNearPrism { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RightBase { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RightAdd { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ColorDistant { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PDDistant { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ColorNear { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PDNear { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSpectaclePresc { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCLensType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSpectacleType { get; set; }

    public DateOnly? DueDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PupilaryDistanceFar { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PupilaryDistanceNear { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FaceWidth { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NoseWidth { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FrameModel { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FrameWidth { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LensColor { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TanggalCetak { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTD { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCLensType")]
    [InverseProperty("SpectaclePrescriptionGCLensTypeNavigation")]
    public virtual sysGeneralCode? GCLensTypeNavigation { get; set; }

    [ForeignKey("GCSpectaclePresc")]
    [InverseProperty("SpectaclePrescriptionGCSpectaclePrescNavigation")]
    public virtual sysGeneralCode? GCSpectaclePrescNavigation { get; set; }

    [ForeignKey("GCSpectacleType")]
    [InverseProperty("SpectaclePrescriptionGCSpectacleTypeNavigation")]
    public virtual sysGeneralCode? GCSpectacleTypeNavigation { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("SpectaclePrescription")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("SpectaclePrescription")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("SpectaclePrescription")]
    public virtual Site? SiteCodeNavigation { get; set; }
}
