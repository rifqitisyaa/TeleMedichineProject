using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimItemPlanning
{
    [Key]
    public int ItemPlanningID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public int ItemIDOri { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MinOrderQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MaxOrderQty { get; set; }

    public byte CumulativeLeadTime { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("ItemPlanning")]
    public virtual ICollection<DW_FactPharmacySales> DW_FactPharmacySales { get; set; } = new List<DW_FactPharmacySales>();
}
