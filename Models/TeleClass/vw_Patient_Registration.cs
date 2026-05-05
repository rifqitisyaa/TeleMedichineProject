using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_Patient_Registration
{
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RegistrationDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AppointmentNo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? ServiceUnitCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? BusinessPartnerCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RoomCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? BedCode { get; set; }

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

    [StringLength(10)]
    [Unicode(false)]
    public string? ParamedicCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ParamedicNurseCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AuthorizedNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AuthorizedDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? AuthorizedAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CustomerDocumentNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CoveredClassCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OriginOfPatientRegName1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OriginOfPatientRegName2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PayerType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PatientInTypeName1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PatientInTypeName2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ShiftName1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ShiftName2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PatientCategoryName1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PatientCategoryName2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DependentTypeName1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DependentTypeName2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CaseTypeName1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CaseTypeName2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TriageName1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TriageName2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DischargeConditionName1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DischargeConditionName2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DischargeMethodName1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DischargeMethodName2 { get; set; }

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

    [StringLength(10)]
    [Unicode(false)]
    public string? DischargeOperatorID { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DischargePlanRemark { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DischargePlanDate { get; set; }

    public bool IsDischarge { get; set; }

    public bool IsDischargePlan { get; set; }

    public bool IsPendingDischarge { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClosedDateTime { get; set; }

    public bool IsClosed { get; set; }

    public bool IsWalkIn { get; set; }

    public bool IsRegistrationMcu { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReservationNo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Anamnesis { get; set; }

    [Unicode(false)]
    public string? PresentIllnessNotes { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? StatusName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferralNo { get; set; }

    public bool IsTransferedToInpatient { get; set; }

    public bool IsNewPatient { get; set; }

    public bool IsNewBornInfant { get; set; }

    public bool IsParturition { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsInvoiced { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TransactionAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? RoundingAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? RemainingAmount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
