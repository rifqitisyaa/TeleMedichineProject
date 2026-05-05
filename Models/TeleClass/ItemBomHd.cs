using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ItemBomHd
{
    [Key]
    public int ItemID { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Uom { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remark { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("ItemBomHd")]
    public virtual Item Item { get; set; } = null!;

    [InverseProperty("ParentItem")]
    public virtual ICollection<ItemBomDt> ItemBomDt { get; set; } = new List<ItemBomDt>();
}
