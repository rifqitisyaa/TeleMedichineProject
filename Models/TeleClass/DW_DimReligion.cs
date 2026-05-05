using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimReligion
{
    [Key]
    public int ReligionID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ReligionCode { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string ReligionName { get; set; } = null!;

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("Religion")]
    public virtual ICollection<DW_DimPatient> DW_DimPatient { get; set; } = new List<DW_DimPatient>();
}
