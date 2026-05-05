using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_FactMaterialCost
{
    [Key]
    public int ID { get; set; }

    public int SiteID { get; set; }

    public int ItemID { get; set; }

    public int DateID { get; set; }

    public int TimeID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MaterialCost { get; set; }

    [ForeignKey("DateID")]
    [InverseProperty("DW_FactMaterialCost")]
    public virtual DW_DimDate Date { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("DW_FactMaterialCost")]
    public virtual DW_DimItem Item { get; set; } = null!;

    [ForeignKey("SiteID")]
    [InverseProperty("DW_FactMaterialCost")]
    public virtual DW_DimSiteCode Site { get; set; } = null!;

    [ForeignKey("TimeID")]
    [InverseProperty("DW_FactMaterialCost")]
    public virtual DW_DimTime Time { get; set; } = null!;
}
