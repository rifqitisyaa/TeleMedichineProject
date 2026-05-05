using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
[Index("CleanedName", Name = "IX_patientyankes223_CleanedName")]
public partial class PatientYankes223
{
    [StringLength(50)]
    [Unicode(false)]
    public string? NomorReferensi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PatientCategory { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Sex { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CityOfBirth { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DateOfBirth { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Alamat { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Position { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? UnitKerja { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MobilePhone1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ZipCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Province { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Religion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MaritalStatus { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Education { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BloodType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NoKtp { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Email1 { get; set; }

    [Unicode(false)]
    public string? Photo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? EmergencyName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EmergencyRelationship { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EmergencyMobilePhone { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(200)]
    public string? CleanedName { get; set; }
}
