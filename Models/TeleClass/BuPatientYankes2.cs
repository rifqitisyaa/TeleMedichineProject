using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class BuPatientYankes2
{
    [StringLength(100)]
    [Unicode(false)]
    public string NomorReferensi { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string PatientCategory { get; set; } = null!;

    [Unicode(false)]
    public string? PatientName { get; set; }

    [Unicode(false)]
    public string? Sex { get; set; }

    [Unicode(false)]
    public string? CityOfBirth { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }

    [Unicode(false)]
    public string? Alamat { get; set; }

    [Unicode(false)]
    public string? Position { get; set; }

    [Unicode(false)]
    public string? UnitKerja { get; set; }

    [Unicode(false)]
    public string? MobilePhone1 { get; set; }

    [Unicode(false)]
    public string? City { get; set; }

    [Unicode(false)]
    public string? ZipCode { get; set; }

    [Unicode(false)]
    public string? Province { get; set; }

    [Unicode(false)]
    public string? Religion { get; set; }

    [Unicode(false)]
    public string? MaritalStatus { get; set; }

    [Unicode(false)]
    public string? Education { get; set; }

    [Unicode(false)]
    public string? BloodType { get; set; }

    [Unicode(false)]
    public string? NoKtp { get; set; }

    [Unicode(false)]
    public string? Email1 { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Photo { get; set; }

    [Unicode(false)]
    public string? EmergencyName { get; set; }

    [Unicode(false)]
    public string? EmergencyRelationship { get; set; }

    [Unicode(false)]
    public string? EmergencyMobilePhone { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
