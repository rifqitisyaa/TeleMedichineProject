using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PatientSummaryControl
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string PatientSummaryControlCode { get; set; } = null!;

    public bool? IsActive { get; set; }

    [InverseProperty("PatientSummaryControlCodeNavigation")]
    public virtual ICollection<PatientSummaryControlParamedicType> PatientSummaryControlParamedicType { get; set; } = new List<PatientSummaryControlParamedicType>();
}
