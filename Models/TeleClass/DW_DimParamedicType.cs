using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimParamedicType
{
    [Key]
    public int ParamedicTypeID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ParamedicTypeCode { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string ParamedicTypeName { get; set; } = null!;

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("ParamedicType")]
    public virtual ICollection<DW_DimParamedic> DW_DimParamedic { get; set; } = new List<DW_DimParamedic>();
}
