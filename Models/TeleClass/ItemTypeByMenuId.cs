using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MenuId", "GCItemType")]
public partial class ItemTypeByMenuId
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MenuId { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCItemType { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
