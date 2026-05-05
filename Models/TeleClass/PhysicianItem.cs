using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PhysicianItem
{
    [Key]
    public int PhysicianItemID { get; set; }

    public int ParamedicID { get; set; }

    public int ItemID { get; set; }

    public bool IsUsingPercentage { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal? FeePercentage { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("PhysicianItem")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ParamedicID")]
    [InverseProperty("PhysicianItem")]
    public virtual Paramedic Paramedic { get; set; } = null!;
}
