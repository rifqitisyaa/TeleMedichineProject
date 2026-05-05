using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("AssetsID", "ModuleSequenceNo")]
public partial class AssetModule
{
    [Key]
    public int AssetsID { get; set; }

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string ModuleSequenceNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ModuleDescription { get; set; } = null!;

    public int Qty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Cost { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("AssetsID")]
    [InverseProperty("AssetModule")]
    public virtual Assets Assets { get; set; } = null!;
}
