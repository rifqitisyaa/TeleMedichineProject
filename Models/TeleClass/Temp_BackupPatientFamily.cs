using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class Temp_BackupPatientFamily
{
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string? FamilyMedicalNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string FamilyName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Job { get; set; }

    [Unicode(false)]
    public string Address { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? PhoneNo { get; set; }

    [StringLength(20)]
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

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
