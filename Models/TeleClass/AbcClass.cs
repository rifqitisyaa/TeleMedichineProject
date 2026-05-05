using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AbcClass
{
    [Key]
    [Column("AbcClass")]
    [StringLength(1)]
    [Unicode(false)]
    public string AbcClass1 { get; set; } = null!;

    [Column(TypeName = "numeric(18, 2)")]
    public decimal ToleranceAmount { get; set; }

    public int ReceivingTimeTolerance { get; set; }

    public int PeriodeInventory { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("AbcClassNavigation")]
    public virtual ICollection<StockTakingHd> StockTakingHd { get; set; } = new List<StockTakingHd>();
}
