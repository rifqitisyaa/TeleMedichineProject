using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimSex
{
    [Key]
    public int SexID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string SexCode { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string SexName { get; set; } = null!;

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("Sex")]
    public virtual ICollection<DW_DimParamedic> DW_DimParamedic { get; set; } = new List<DW_DimParamedic>();

    [InverseProperty("Sex")]
    public virtual ICollection<DW_DimPatient> DW_DimPatient { get; set; } = new List<DW_DimPatient>();
}
