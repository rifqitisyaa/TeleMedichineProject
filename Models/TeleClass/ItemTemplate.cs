using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ItemTemplate
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string JobOrderType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Title { get; set; }

    public int? ItemID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ControlType { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string OrderNo { get; set; } = null!;

    public int? HeaderId { get; set; }

    public bool IsHeader { get; set; }

    public bool IsBold { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("ItemTemplate")]
    public virtual Item? Item { get; set; }
}
