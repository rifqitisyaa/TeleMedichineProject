using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimItemUnit
{
    [Key]
    public int ItemUnitId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemUnitCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemUnitName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? ShortName { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("ItemUnit")]
    public virtual ICollection<DW_FactBalanceStock> DW_FactBalanceStock { get; set; } = new List<DW_FactBalanceStock>();

    [InverseProperty("ItemUnit")]
    public virtual ICollection<DW_FactFEFOIn> DW_FactFEFOIn { get; set; } = new List<DW_FactFEFOIn>();

    [InverseProperty("ItemUnit")]
    public virtual ICollection<DW_FactFEFOInPeriode> DW_FactFEFOInPeriode { get; set; } = new List<DW_FactFEFOInPeriode>();

    [InverseProperty("ItemUnit")]
    public virtual ICollection<DW_FactFEFOOut> DW_FactFEFOOut { get; set; } = new List<DW_FactFEFOOut>();

    [InverseProperty("ItemUnit")]
    public virtual ICollection<DW_FactFIFOIn> DW_FactFIFOIn { get; set; } = new List<DW_FactFIFOIn>();

    [InverseProperty("ItemUnit")]
    public virtual ICollection<DW_FactFIFOInPeriode> DW_FactFIFOInPeriode { get; set; } = new List<DW_FactFIFOInPeriode>();

    [InverseProperty("ItemUnit")]
    public virtual ICollection<DW_FactFIFOOut> DW_FactFIFOOut { get; set; } = new List<DW_FactFIFOOut>();

    [InverseProperty("ItemUnit")]
    public virtual ICollection<DW_FactPharmacySales> DW_FactPharmacySales { get; set; } = new List<DW_FactPharmacySales>();
}
