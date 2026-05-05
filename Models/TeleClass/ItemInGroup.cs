using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ItemInGroup
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string RecordCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? JobOrderType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ParentName { get; set; }

    public int? ItemId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ParentCode { get; set; }

    public bool IsParent { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("ParentCodeNavigation")]
    public virtual ICollection<ItemInGroup> InverseParentCodeNavigation { get; set; } = new List<ItemInGroup>();

    [ForeignKey("ItemId")]
    [InverseProperty("ItemInGroup")]
    public virtual Item? Item { get; set; }

    [ForeignKey("ParentCode")]
    [InverseProperty("InverseParentCodeNavigation")]
    public virtual ItemInGroup? ParentCodeNavigation { get; set; }
}
