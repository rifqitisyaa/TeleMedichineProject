using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class registrationDischargeTemp
{
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? TransactionCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RegistrationDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AppointmentNo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    public int ServiceUnitID { get; set; }

    public int? ParamedicID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SpecialtyCode { get; set; }

    public int? NurseID { get; set; }

    public int? RoomID { get; set; }

    public int? BedID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? VisitTypeCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? WorkStationCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? VisitReasonCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ChargeClassCode { get; set; } = null!;

    public int BusinessPartnerID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PayerType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BpjsSepNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCPatientInType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCShiftID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCPatientCategory { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDependentType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCERCaseType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCTriage { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDischargeCondition { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDischargeMethod { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCOriginOfPatientReg { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LinkRegistrationNo { get; set; }

    public int? OriginalServiceUnitID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? OriginalClassCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? OriginalChargeClassCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? OriginalSpecialtyCode { get; set; }

    public int? OriginalBedID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DischargePlanDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DischargeDateTime { get; set; }

    [Unicode(false)]
    public string? DischargeMedicalNotes { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DischargeNotes { get; set; }

    [Column(TypeName = "numeric(3, 0)")]
    public decimal? LOSInDay { get; set; }

    [Column(TypeName = "numeric(3, 0)")]
    public decimal? LOSInHour { get; set; }

    [Column(TypeName = "numeric(3, 0)")]
    public decimal? LOSInMinute { get; set; }

    public DateOnly? ResponseDate { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ResponseTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DischargeOperatorID { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? AccountNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AuthorizedNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AuthorizedDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TransactionAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? AdministrationAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? RoundingAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? RemainingAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? AuthorizedAmount { get; set; }

    public bool IsTransferedToInpatient { get; set; }

    public bool IsNewPatient { get; set; }

    public bool IsNewBornInfant { get; set; }

    public bool IsParturition { get; set; }

    public byte RevisionNo { get; set; }

    public bool IsHoldTransactionEntry { get; set; }

    public bool IsPrintingPatientCard { get; set; }

    public bool IsClosed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClosedDateTime { get; set; }

    public bool IsBackDate { get; set; }

    public bool IsDischargePlan { get; set; }

    public bool IsDischarge { get; set; }

    public bool IsPendingDischarge { get; set; }

    public bool IsInvoiced { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RefreshIndicator { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActualVisitDateTime { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Anamnesis { get; set; }

    [Unicode(false)]
    public string? PresentIllnessNotes { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CustomerDocumentNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CoveredClassCode { get; set; }

    public int? StatusID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferralNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCReferralType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferralBy { get; set; }

    public bool IsBedConfirmed { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DischargePlanRemark { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? EntryBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EntryDateTime { get; set; }

    public bool IsAttend { get; set; }

    public bool IsNotAttend { get; set; }

    public bool IsWalkIn { get; set; }

    public bool IsRegistrationMcu { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReservationNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Comunity { get; set; }

    public bool? IsUsedAmbulance { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
