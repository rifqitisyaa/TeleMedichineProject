using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
[Index("CleanedName", Name = "IX_patient23_CleanedName")]
public partial class Patient23
{
    [StringLength(50)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    public int? SiteCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SSN { get; set; }

    public DateTime? Since { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MiddleName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PreferredName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PatientNameOnCard { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CityOfBirth { get; set; }

    public DateTime? DateOfBirth { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IsApproximateDOB { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GCSex { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GCBloodType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BloodRhesus { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GCEducation { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GCMaritalStatus { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GCNationality { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GCRace { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? SpokenLanguage { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? WrittenLanguage { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GCOccupation { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Title { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Suffix { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GCPatientCategory { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? GCDependentType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GCReligion { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Company { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Position { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MobilePhoneNo1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MobilePhoneNo2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OldMedicalNo { get; set; }

    [Unicode(false)]
    public string? Picture { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? PictureFileName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IsBlackList { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? BlackListBy { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BlackListDateTime { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? BlackListNotes { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IsAlive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DateOfDeath { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastVisitDate { get; set; }

    public double? NumberOfVisit { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? RegistrationNoOfDeath { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? BpjsCardNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IsPatientConfidential { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(200)]
    public string? CleanedName { get; set; }
}
