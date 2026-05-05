using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimEducation
{
    [Key]
    public int EducationID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string EducationCode { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string EducationName { get; set; } = null!;

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("Education")]
    public virtual ICollection<DW_DimPatient> DW_DimPatient { get; set; } = new List<DW_DimPatient>();
}
