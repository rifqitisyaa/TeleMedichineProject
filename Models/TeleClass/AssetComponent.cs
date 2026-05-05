using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("AssetsID", "TagNo")]
public partial class AssetComponent
{
    [Key]
    public int AssetsID { get; set; }

    [Key]
    [StringLength(35)]
    [Unicode(false)]
    public string TagNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? Cost { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SerialNumber { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("AssetsID")]
    [InverseProperty("AssetComponent")]
    public virtual Assets Assets { get; set; } = null!;
}
