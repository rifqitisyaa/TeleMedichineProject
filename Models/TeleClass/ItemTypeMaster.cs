using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("GCItemType", "GCItemMaster")]
public partial class ItemTypeMaster
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCItemType { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCItemMaster { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCItemMaster")]
    [InverseProperty("ItemTypeMasterGCItemMasterNavigation")]
    public virtual sysGeneralCode GCItemMasterNavigation { get; set; } = null!;

    [ForeignKey("GCItemType")]
    [InverseProperty("ItemTypeMasterGCItemTypeNavigation")]
    public virtual sysGeneralCode GCItemTypeNavigation { get; set; } = null!;
}
