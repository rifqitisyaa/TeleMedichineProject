using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("PatientSummaryControlCode", "GCParamedicType")]
public partial class PatientSummaryControlParamedicType
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string PatientSummaryControlCode { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCParamedicType { get; set; } = null!;

    public bool? IsActive { get; set; }

    [ForeignKey("GCParamedicType")]
    [InverseProperty("PatientSummaryControlParamedicType")]
    public virtual PatientSummaryParamedicType GCParamedicTypeNavigation { get; set; } = null!;

    [ForeignKey("PatientSummaryControlCode")]
    [InverseProperty("PatientSummaryControlParamedicType")]
    public virtual PatientSummaryControl PatientSummaryControlCodeNavigation { get; set; } = null!;
}
