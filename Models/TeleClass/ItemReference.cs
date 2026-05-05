using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ItemReference
{
    [Key]
    public int ReferenceId { get; set; }

    public int ItemId { get; set; }

    [Column(TypeName = "image")]
    public byte[] ImageItem { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? ImageUrl { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ItemReference")]
    public virtual Item Item { get; set; } = null!;
}
