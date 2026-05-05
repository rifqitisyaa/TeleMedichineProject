using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimABCClass
{
    [Key]
    public int ABCClassID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string ABCClass { get; set; } = null!;

    [Column(TypeName = "numeric(18, 2)")]
    public decimal ToleranceAmount { get; set; }

    public int ReceivingTimeTolerance { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("ABCClass")]
    public virtual ICollection<DW_DimItem> DW_DimItem { get; set; } = new List<DW_DimItem>();
}
