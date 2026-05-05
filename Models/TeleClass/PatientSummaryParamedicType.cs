using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PatientSummaryParamedicType
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCParamedicType { get; set; } = null!;

    public int? OrderNo { get; set; }

    public bool? IsActive { get; set; }

    [InverseProperty("GCParamedicTypeNavigation")]
    public virtual ICollection<PatientSummaryControlParamedicType> PatientSummaryControlParamedicType { get; set; } = new List<PatientSummaryControlParamedicType>();
}
