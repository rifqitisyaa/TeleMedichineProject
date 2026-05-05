using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Paramedic
{
    [Key]
    public int ParamedicID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ParamedicCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string FirstName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string MiddleName { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string LastName { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string ParamedicName { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string ParamedicInitial { get; set; } = null!;

    public DateOnly? DateOfBirth { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSex { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCParamedicType { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? STR { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCEmploymentStatus { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCReligion { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCNationality { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Title { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Suffix { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SpecialtyCode { get; set; }

    public DateOnly? HiredDate { get; set; }

    public DateOnly? TerminatedDate { get; set; }

    public DateOnly? StartExperienceDate { get; set; }

    public bool IsTaxRegistrant { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string TaxRegistrantNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LicenseNo { get; set; } = null!;

    public DateOnly? LicenseExpiredDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PictureFileName { get; set; } = null!;

    public bool IsAvailable { get; set; }

    public DateOnly? NotAvailableUntil { get; set; }

    public bool IsAnesthetist { get; set; }

    public bool IsAudiologist { get; set; }

    public bool IsHasPhysicianRole { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? UserName { get; set; }

    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsFeeUsingPercentage { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal FeeAmount { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal? FeePercentage { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BankName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BankAccountNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BankAccountName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SSN { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Paramedic")]
    public virtual ICollection<CancelPatientVisit> CancelPatientVisit { get; set; } = new List<CancelPatientVisit>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<CompoundTemplateHd> CompoundTemplateHd { get; set; } = new List<CompoundTemplateHd>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<CustomerParamedic> CustomerParamedic { get; set; } = new List<CustomerParamedic>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<DiscountPhysician> DiscountPhysician { get; set; } = new List<DiscountPhysician>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<DrugDispensingHd> DrugDispensingHd { get; set; } = new List<DrugDispensingHd>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<EpisodeDiagnosis> EpisodeDiagnosis { get; set; } = new List<EpisodeDiagnosis>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<EpisodeProcedure> EpisodeProcedure { get; set; } = new List<EpisodeProcedure>();

    [ForeignKey("GCEmploymentStatus")]
    [InverseProperty("ParamedicGCEmploymentStatusNavigation")]
    public virtual sysGeneralCode? GCEmploymentStatusNavigation { get; set; }

    [ForeignKey("GCNationality")]
    [InverseProperty("ParamedicGCNationalityNavigation")]
    public virtual sysGeneralCode? GCNationalityNavigation { get; set; }

    [ForeignKey("GCParamedicType")]
    [InverseProperty("ParamedicGCParamedicTypeNavigation")]
    public virtual sysGeneralCode? GCParamedicTypeNavigation { get; set; }

    [ForeignKey("GCReligion")]
    [InverseProperty("ParamedicGCReligionNavigation")]
    public virtual sysGeneralCode? GCReligionNavigation { get; set; }

    [ForeignKey("GCSex")]
    [InverseProperty("ParamedicGCSexNavigation")]
    public virtual sysGeneralCode? GCSexNavigation { get; set; }

    [InverseProperty("Paramedic")]
    public virtual ICollection<IPAddressQueue> IPAddressQueue { get; set; } = new List<IPAddressQueue>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<ItemServiceMCURealizationDt> ItemServiceMCURealizationDt { get; set; } = new List<ItemServiceMCURealizationDt>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<ItemTransactionMcuDt> ItemTransactionMcuDt { get; set; } = new List<ItemTransactionMcuDt>();

    [InverseProperty("ReviewByParamedicNavigation")]
    public virtual ICollection<JobOrderBOMImaging> JobOrderBOMImaging { get; set; } = new List<JobOrderBOMImaging>();

    [InverseProperty("AutorizedBy")]
    public virtual ICollection<JobOrderBOMOtherExam> JobOrderBOMOtherExam { get; set; } = new List<JobOrderBOMOtherExam>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<JobOrderDtMedication> JobOrderDtMedication { get; set; } = new List<JobOrderDtMedication>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<JobOrderHd> JobOrderHd { get; set; } = new List<JobOrderHd>();

    [InverseProperty("FromNurse")]
    public virtual ICollection<NurseShiftTransferHistoryHd> NurseShiftTransferHistoryHdFromNurse { get; set; } = new List<NurseShiftTransferHistoryHd>();

    [InverseProperty("ToNurse")]
    public virtual ICollection<NurseShiftTransferHistoryHd> NurseShiftTransferHistoryHdToNurse { get; set; } = new List<NurseShiftTransferHistoryHd>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PackageTreatmentDt> PackageTreatmentDt { get; set; } = new List<PackageTreatmentDt>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<ParamedicAutoBill> ParamedicAutoBill { get; set; } = new List<ParamedicAutoBill>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<ParamedicCertificate> ParamedicCertificate { get; set; } = new List<ParamedicCertificate>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<ParamedicItemMcu> ParamedicItemMcu { get; set; } = new List<ParamedicItemMcu>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<ParamedicVisitType> ParamedicVisitType { get; set; } = new List<ParamedicVisitType>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PatientAPGAR> PatientAPGAR { get; set; } = new List<PatientAPGAR>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PatientAttendance> PatientAttendance { get; set; } = new List<PatientAttendance>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PatientBPU> PatientBPU { get; set; } = new List<PatientBPU>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PatientCAPPIRO> PatientCAPPIRO { get; set; } = new List<PatientCAPPIRO>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PatientCHDRisk> PatientCHDRisk { get; set; } = new List<PatientCHDRisk>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PatientCancel> PatientCancel { get; set; } = new List<PatientCancel>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PatientFCS> PatientFCS { get; set; } = new List<PatientFCS>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PatientGCS> PatientGCS { get; set; } = new List<PatientGCS>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PatientGCSPediatric> PatientGCSPediatric { get; set; } = new List<PatientGCSPediatric>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PatientMCUCompileHd> PatientMCUCompileHd { get; set; } = new List<PatientMCUCompileHd>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PatientNotes> PatientNotesParamedic { get; set; } = new List<PatientNotes>();

    [InverseProperty("ParamedicToNavigation")]
    public virtual ICollection<PatientNotes> PatientNotesParamedicToNavigation { get; set; } = new List<PatientNotes>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PatientQuestionaireHd> PatientQuestionaireHd { get; set; } = new List<PatientQuestionaireHd>();

    [InverseProperty("OriginNurse")]
    public virtual ICollection<PatientResponsibleLog> PatientResponsibleLogOriginNurse { get; set; } = new List<PatientResponsibleLog>();

    [InverseProperty("OriginPhyisician")]
    public virtual ICollection<PatientResponsibleLog> PatientResponsibleLogOriginPhyisician { get; set; } = new List<PatientResponsibleLog>();

    [InverseProperty("ResponsibleNurse")]
    public virtual ICollection<PatientResponsibleLog> PatientResponsibleLogResponsibleNurse { get; set; } = new List<PatientResponsibleLog>();

    [InverseProperty("ResponsiblePhysician")]
    public virtual ICollection<PatientResponsibleLog> PatientResponsibleLogResponsiblePhysician { get; set; } = new List<PatientResponsibleLog>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PhysicianBilling> PhysicianBilling { get; set; } = new List<PhysicianBilling>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PhysicianChargesByClass> PhysicianChargesByClass { get; set; } = new List<PhysicianChargesByClass>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PhysicianFeeItem> PhysicianFeeItem { get; set; } = new List<PhysicianFeeItem>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PhysicianFeeItemJobOrder> PhysicianFeeItemJobOrder { get; set; } = new List<PhysicianFeeItemJobOrder>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PhysicianFeePaymentPlanHd> PhysicianFeePaymentPlanHd { get; set; } = new List<PhysicianFeePaymentPlanHd>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PhysicianFeeVerification> PhysicianFeeVerification { get; set; } = new List<PhysicianFeeVerification>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PhysicianItem> PhysicianItem { get; set; } = new List<PhysicianItem>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PhysicianRMO> PhysicianRMO { get; set; } = new List<PhysicianRMO>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PhysicianTaxSummaryHd> PhysicianTaxSummaryHd { get; set; } = new List<PhysicianTaxSummaryHd>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PhysicianTeam> PhysicianTeam { get; set; } = new List<PhysicianTeam>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PhysicianTeamSurgery> PhysicianTeamSurgery { get; set; } = new List<PhysicianTeamSurgery>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<PrescriptionTemplateHd> PrescriptionTemplateHd { get; set; } = new List<PrescriptionTemplateHd>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<Queuing> Queuing { get; set; } = new List<Queuing>();

    [InverseProperty("ParamedicIDFromNavigation")]
    public virtual ICollection<ReferToConsult> ReferToConsultParamedicIDFromNavigation { get; set; } = new List<ReferToConsult>();

    [InverseProperty("ParamedicIDToNavigation")]
    public virtual ICollection<ReferToConsult> ReferToConsultParamedicIDToNavigation { get; set; } = new List<ReferToConsult>();

    [InverseProperty("Nurse")]
    public virtual ICollection<Registration> RegistrationNurse { get; set; } = new List<Registration>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<Registration> RegistrationParamedic { get; set; } = new List<Registration>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<RiskFallHd> RiskFallHd { get; set; } = new List<RiskFallHd>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<ServiceUnitParamedic> ServiceUnitParamedic { get; set; } = new List<ServiceUnitParamedic>();

    [ForeignKey("SiteCode")]
    [InverseProperty("Paramedic")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("SpecialtyCode")]
    [InverseProperty("Paramedic")]
    public virtual Specialty? SpecialtyCodeNavigation { get; set; }

    [InverseProperty("Paramedic")]
    public virtual ICollection<SurgeryReservation> SurgeryReservation { get; set; } = new List<SurgeryReservation>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<SurgeryTeamTemplateDt> SurgeryTeamTemplateDt { get; set; } = new List<SurgeryTeamTemplateDt>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<TemplateOtherExam> TemplateOtherExam { get; set; } = new List<TemplateOtherExam>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<TemplateRadiology> TemplateRadiology { get; set; } = new List<TemplateRadiology>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<TransactionChargesDt> TransactionChargesDt { get; set; } = new List<TransactionChargesDt>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<VaccinationShotHd> VaccinationShotHd { get; set; } = new List<VaccinationShotHd>();

    [InverseProperty("Paramedic")]
    public virtual ICollection<WorkStation> WorkStation { get; set; } = new List<WorkStation>();
}
