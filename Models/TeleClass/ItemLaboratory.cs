using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ItemLaboratory
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    public int Position { get; set; }

    public int? ItemId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("ItemLaboratoryItem")]
    public virtual Item? Item { get; set; }

    [ForeignKey("ItemCode")]
    [InverseProperty("ItemLaboratoryItemCodeNavigation")]
    public virtual Item ItemCodeNavigation { get; set; } = null!;
}
