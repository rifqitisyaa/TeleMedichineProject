using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("FirstName", Name = "IX_Patient")]
[Index("LastName", Name = "IX_Patient_1")]
public partial class Patient
{
    [Key]
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

    [StringLength(500)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? MiddleName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PreferredName { get; set; }

    [StringLength(500)]
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

    [StringLength(200)]
    [Unicode(false)]
    public string? Company { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Position { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? MobilePhoneNo1 { get; set; }

    [StringLength(30)]
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

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<Appointment> Appointment { get; set; } = new List<Appointment>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<BedCleaning> BedCleaning { get; set; } = new List<BedCleaning>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<BedReservation> BedReservation { get; set; } = new List<BedReservation>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<CurrentPregnancy> CurrentPregnancy { get; set; } = new List<CurrentPregnancy>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<FetalMeasurementHd> FetalMeasurementHd { get; set; } = new List<FetalMeasurementHd>();

    [ForeignKey("GCBloodType")]
    [InverseProperty("PatientGCBloodTypeNavigation")]
    public virtual sysGeneralCode? GCBloodTypeNavigation { get; set; }

    [ForeignKey("GCDependentType")]
    [InverseProperty("PatientGCDependentTypeNavigation")]
    public virtual sysGeneralCode? GCDependentTypeNavigation { get; set; }

    [ForeignKey("GCEducation")]
    [InverseProperty("PatientGCEducationNavigation")]
    public virtual sysGeneralCode? GCEducationNavigation { get; set; }

    [ForeignKey("GCMaritalStatus")]
    [InverseProperty("PatientGCMaritalStatusNavigation")]
    public virtual sysGeneralCode? GCMaritalStatusNavigation { get; set; }

    [ForeignKey("GCNationality")]
    [InverseProperty("PatientGCNationalityNavigation")]
    public virtual sysGeneralCode? GCNationalityNavigation { get; set; }

    [ForeignKey("GCOccupation")]
    [InverseProperty("PatientGCOccupationNavigation")]
    public virtual sysGeneralCode? GCOccupationNavigation { get; set; }

    [ForeignKey("GCPatientCategory")]
    [InverseProperty("PatientGCPatientCategoryNavigation")]
    public virtual sysGeneralCode? GCPatientCategoryNavigation { get; set; }

    [ForeignKey("GCRace")]
    [InverseProperty("PatientGCRaceNavigation")]
    public virtual sysGeneralCode? GCRaceNavigation { get; set; }

    [ForeignKey("GCReligion")]
    [InverseProperty("PatientGCReligionNavigation")]
    public virtual sysGeneralCode? GCReligionNavigation { get; set; }

    [ForeignKey("GCSex")]
    [InverseProperty("PatientGCSexNavigation")]
    public virtual sysGeneralCode GCSexNavigation { get; set; } = null!;

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<MobileMembership> MobileMembership { get; set; } = new List<MobileMembership>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<MorseFallScore> MorseFallScore { get; set; } = new List<MorseFallScore>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<OdontogramMCU> OdontogramMCU { get; set; } = new List<OdontogramMCU>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<PatientAPGAR> PatientAPGAR { get; set; } = new List<PatientAPGAR>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<PatientAllergy> PatientAllergy { get; set; } = new List<PatientAllergy>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<PatientAntibiotik> PatientAntibiotik { get; set; } = new List<PatientAntibiotik>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<PatientBPU> PatientBPU { get; set; } = new List<PatientBPU>();

    [InverseProperty("MotherMedicalNoNavigation")]
    public virtual ICollection<PatientBirthRecord> PatientBirthRecord { get; set; } = new List<PatientBirthRecord>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<PatientBlackList> PatientBlackList { get; set; } = new List<PatientBlackList>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<PatientCAPPIRO> PatientCAPPIRO { get; set; } = new List<PatientCAPPIRO>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<PatientCHDRisk> PatientCHDRisk { get; set; } = new List<PatientCHDRisk>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<PatientDocument> PatientDocument { get; set; } = new List<PatientDocument>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<PatientFCS> PatientFCS { get; set; } = new List<PatientFCS>();

    [InverseProperty("FamilyMedicalNoNavigation")]
    public virtual ICollection<PatientFamily> PatientFamilyFamilyMedicalNoNavigation { get; set; } = new List<PatientFamily>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<PatientFamily> PatientFamilyMedicalNoNavigation { get; set; } = new List<PatientFamily>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<PatientGCS> PatientGCS { get; set; } = new List<PatientGCS>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<PatientGCSPediatric> PatientGCSPediatric { get; set; } = new List<PatientGCSPediatric>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<PatientInfectiousDisease> PatientInfectiousDisease { get; set; } = new List<PatientInfectiousDisease>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<PatientOdontogram> PatientOdontogram { get; set; } = new List<PatientOdontogram>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<PatientOdontogramNew> PatientOdontogramNew { get; set; } = new List<PatientOdontogramNew>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<PatientPayerCard> PatientPayerCard { get; set; } = new List<PatientPayerCard>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<PatientProblem> PatientProblem { get; set; } = new List<PatientProblem>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual PatientTagField? PatientTagField { get; set; }

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<PatientVaccination> PatientVaccination { get; set; } = new List<PatientVaccination>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<PatientVision> PatientVision { get; set; } = new List<PatientVision>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<RL2Imunisasi> RL2Imunisasi { get; set; } = new List<RL2Imunisasi>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<ReferralPatient> ReferralPatient { get; set; } = new List<ReferralPatient>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<Registration> Registration { get; set; } = new List<Registration>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<ReportedMedication> ReportedMedication { get; set; } = new List<ReportedMedication>();

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<RiskFallHd> RiskFallHd { get; set; } = new List<RiskFallHd>();

    [ForeignKey("SiteCode")]
    [InverseProperty("Patient")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [InverseProperty("MedicalNoNavigation")]
    public virtual ICollection<SpectaclePrescription> SpectaclePrescription { get; set; } = new List<SpectaclePrescription>();
}
