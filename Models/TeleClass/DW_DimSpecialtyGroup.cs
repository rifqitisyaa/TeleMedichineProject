using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimSpecialtyGroup
{
    [Key]
    public int SpecialtyGroupID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string SpecialtyGroupCode { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string SpecialtyGroupName { get; set; } = null!;

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("SpecialtyGroup")]
    public virtual ICollection<DW_DimSpecialty> DW_DimSpecialty { get; set; } = new List<DW_DimSpecialty>();
}
