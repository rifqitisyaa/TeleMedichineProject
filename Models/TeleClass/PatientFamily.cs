using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class PatientFamily
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string? FamilyMedicalNo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string FamilyName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Job { get; set; }

    [Unicode(false)]
    public string Address { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? PhoneNo { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? MobilePhoneNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCRelationShip { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SSN { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Picture { get; set; }

    public bool IsEmergencyContact { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("FamilyMedicalNo")]
    [InverseProperty("PatientFamilyFamilyMedicalNoNavigation")]
    public virtual Patient? FamilyMedicalNoNavigation { get; set; }

    [ForeignKey("GCRelationShip")]
    [InverseProperty("PatientFamily")]
    public virtual sysGeneralCode? GCRelationShipNavigation { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("PatientFamilyMedicalNoNavigation")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;
}
