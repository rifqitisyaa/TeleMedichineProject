using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NurseShiftTransferHistoryDt
{
    [Key]
    public long DetailId { get; set; }

    public long TransferId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Detail")]
    public virtual ICollection<NsDrugAdministration> NsDrugAdministration { get; set; } = new List<NsDrugAdministration>();

    [InverseProperty("Detail")]
    public virtual ICollection<NsJobOrderBOMImaging> NsJobOrderBOMImaging { get; set; } = new List<NsJobOrderBOMImaging>();

    [InverseProperty("Detail")]
    public virtual ICollection<NsJobOrderBOMLaboratory> NsJobOrderBOMLaboratory { get; set; } = new List<NsJobOrderBOMLaboratory>();

    [InverseProperty("Detail")]
    public virtual ICollection<NsJobOrderBOMOtherExam> NsJobOrderBOMOtherExam { get; set; } = new List<NsJobOrderBOMOtherExam>();

    [InverseProperty("Detail")]
    public virtual ICollection<NsJobOrderDt> NsJobOrderDt { get; set; } = new List<NsJobOrderDt>();

    [InverseProperty("Detail")]
    public virtual ICollection<NsJobOrderDtDiagnose> NsJobOrderDtDiagnose { get; set; } = new List<NsJobOrderDtDiagnose>();

    [InverseProperty("Detail")]
    public virtual ICollection<NsJobOrderDtMedication> NsJobOrderDtMedication { get; set; } = new List<NsJobOrderDtMedication>();

    [InverseProperty("Detail")]
    public virtual ICollection<NsJobOrderDtMonitoring> NsJobOrderDtMonitoring { get; set; } = new List<NsJobOrderDtMonitoring>();

    [InverseProperty("Detail")]
    public virtual ICollection<NsJobOrderHd> NsJobOrderHd { get; set; } = new List<NsJobOrderHd>();

    [InverseProperty("Detail")]
    public virtual ICollection<NsMonitoringAdministration> NsMonitoringAdministration { get; set; } = new List<NsMonitoringAdministration>();

    [InverseProperty("Detail")]
    public virtual ICollection<NsNursingCareplan> NsNursingCareplan { get; set; } = new List<NsNursingCareplan>();

    [InverseProperty("Detail")]
    public virtual ICollection<NsNursingCareplanCharacteristic> NsNursingCareplanCharacteristic { get; set; } = new List<NsNursingCareplanCharacteristic>();

    [InverseProperty("Detail")]
    public virtual ICollection<NsNursingCareplanIntervention> NsNursingCareplanIntervention { get; set; } = new List<NsNursingCareplanIntervention>();

    [InverseProperty("Detail")]
    public virtual ICollection<NsNursingCareplanInterventionActivity> NsNursingCareplanInterventionActivity { get; set; } = new List<NsNursingCareplanInterventionActivity>();

    [InverseProperty("Detail")]
    public virtual ICollection<NsNursingCareplanOutcome> NsNursingCareplanOutcome { get; set; } = new List<NsNursingCareplanOutcome>();

    [InverseProperty("Detail")]
    public virtual ICollection<NsNursingCareplanOutcomeResult> NsNursingCareplanOutcomeResult { get; set; } = new List<NsNursingCareplanOutcomeResult>();

    [InverseProperty("Detail")]
    public virtual ICollection<NsNursingCareplanRelatedFactor> NsNursingCareplanRelatedFactor { get; set; } = new List<NsNursingCareplanRelatedFactor>();

    [InverseProperty("Detail")]
    public virtual ICollection<NsNursingCareplanRiskFactor> NsNursingCareplanRiskFactor { get; set; } = new List<NsNursingCareplanRiskFactor>();

    [InverseProperty("Detail")]
    public virtual ICollection<NsOtherExamResultAttachment> NsOtherExamResultAttachment { get; set; } = new List<NsOtherExamResultAttachment>();

    [ForeignKey("RegistrationNo")]
    [InverseProperty("NurseShiftTransferHistoryDt")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("TransferId")]
    [InverseProperty("NurseShiftTransferHistoryDt")]
    public virtual NurseShiftTransferHistoryHd Transfer { get; set; } = null!;
}
