using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimSpecialty
{
    [Key]
    public int SpecialtyID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SpecialtyCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string SpecialtyName1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string SpecialtyName2 { get; set; } = null!;

    public int SpecialtyGroupID { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("Specialty")]
    public virtual ICollection<DW_DimParamedic> DW_DimParamedic { get; set; } = new List<DW_DimParamedic>();

    [ForeignKey("SpecialtyGroupID")]
    [InverseProperty("DW_DimSpecialty")]
    public virtual DW_DimSpecialtyGroup SpecialtyGroup { get; set; } = null!;
}
