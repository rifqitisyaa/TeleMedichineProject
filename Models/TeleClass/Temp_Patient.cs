using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class Temp_Patient
{
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

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
    public string? FirstName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MiddleName { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? PreferredName { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientNameOnCard { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CityOfBirth { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateOfBirth { get; set; }

    public bool IsApproximateDOB { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCSex { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCBloodType { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BloodRhesus { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCEducation { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCMaritalStatus { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCNationality { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCRace { get; set; }

    [Unicode(false)]
    public string? SpokenLanguage { get; set; }

    [Unicode(false)]
    public string? WrittenLanguage { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCOccupation { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Title { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Suffix { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCPatientCategory { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDependentType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCReligion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Company { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Position { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MobilePhoneNo1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MobilePhoneNo2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? OldMedicalNo { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Picture { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PictureFileName { get; set; }

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

    [StringLength(100)]
    [Unicode(false)]
    public string? BpjsCardNo { get; set; }

    public bool IsPatientConfidential { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
