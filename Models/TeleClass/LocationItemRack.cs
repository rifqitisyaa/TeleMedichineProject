using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("LocationId", "ItemId")]
public partial class LocationItemRack
{
    [Key]
    public int LocationId { get; set; }

    [Key]
    public int ItemId { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string RackPosition { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("LocationItemRack")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("LocationId")]
    [InverseProperty("LocationItemRack")]
    public virtual Location Location { get; set; } = null!;
}
