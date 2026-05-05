using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class BackupPatientLookUp
{
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? OldMedicalNo { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Title { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MiddleName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Suffix { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DateBirth { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PhoneNo1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MobilePhoneNo1 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? GeneralCodeName1 { get; set; }

    public bool IsAlive { get; set; }
}
