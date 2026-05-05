using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimItem
{
    [Key]
    public int ItemID { get; set; }

    public int? ItemIdOri { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemName1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? ItemName2 { get; set; }

    public int? ItemTypeID { get; set; }

    public int? ItemGroupID { get; set; }

    public int? ABCClassID { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    [ForeignKey("ABCClassID")]
    [InverseProperty("DW_DimItem")]
    public virtual DW_DimABCClass? ABCClass { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<DW_FactBalanceStock> DW_FactBalanceStock { get; set; } = new List<DW_FactBalanceStock>();

    [InverseProperty("Item")]
    public virtual ICollection<DW_FactFEFOIn> DW_FactFEFOIn { get; set; } = new List<DW_FactFEFOIn>();

    [InverseProperty("Item")]
    public virtual ICollection<DW_FactFEFOInPeriode> DW_FactFEFOInPeriode { get; set; } = new List<DW_FactFEFOInPeriode>();

    [InverseProperty("Item")]
    public virtual ICollection<DW_FactFEFOOut> DW_FactFEFOOut { get; set; } = new List<DW_FactFEFOOut>();

    [InverseProperty("Item")]
    public virtual ICollection<DW_FactFIFOIn> DW_FactFIFOIn { get; set; } = new List<DW_FactFIFOIn>();

    [InverseProperty("Item")]
    public virtual ICollection<DW_FactFIFOInPeriode> DW_FactFIFOInPeriode { get; set; } = new List<DW_FactFIFOInPeriode>();

    [InverseProperty("Item")]
    public virtual ICollection<DW_FactFIFOOut> DW_FactFIFOOut { get; set; } = new List<DW_FactFIFOOut>();

    [InverseProperty("Item")]
    public virtual ICollection<DW_FactMaterialCost> DW_FactMaterialCost { get; set; } = new List<DW_FactMaterialCost>();

    [InverseProperty("Item")]
    public virtual ICollection<DW_FactPharmacySales> DW_FactPharmacySales { get; set; } = new List<DW_FactPharmacySales>();

    [ForeignKey("ItemGroupID")]
    [InverseProperty("DW_DimItem")]
    public virtual DW_DimItemGroup? ItemGroup { get; set; }

    [ForeignKey("ItemTypeID")]
    [InverseProperty("DW_DimItem")]
    public virtual DW_DimItemType? ItemType { get; set; }
}
