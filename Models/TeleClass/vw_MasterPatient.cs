using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_MasterPatient
{
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? OldMedicalNo { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Picture { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PictureFileName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? SSN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Since { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientNameOnCard { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CityOfBirth { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateOfBirth { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Sex { get; set; }

    [StringLength(102)]
    [Unicode(false)]
    public string? BloodType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Education { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MaritalStatus { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Nationality { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Race { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Occupation { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PatientCategory { get; set; }

    [Unicode(false)]
    public string? SpokenLanguage { get; set; }

    [Unicode(false)]
    public string? WrittenLanguage { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DependentType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Religion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Company { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MobilePhoneNo1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MobilePhoneNo2 { get; set; }

    public bool IsBlackList { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? BlackListBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BlackListDateTime { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? BlackListNotes { get; set; }

    public bool IsAlive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfDeath { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastVisitDate { get; set; }

    [Column(TypeName = "numeric(5, 0)")]
    public decimal NumberOfVisit { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNoOfDeath { get; set; }

    public bool IsPatientConfidential { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
