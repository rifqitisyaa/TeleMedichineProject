using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ItemMasterIncentive
{
    [Key]
    public int ID { get; set; }

    public int ItemID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCProfile { get; set; } = null!;

    [StringLength(25)]
    [Unicode(false)]
    public string? Amount { get; set; }

    public bool IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCProfile")]
    [InverseProperty("ItemMasterIncentive")]
    public virtual sysGeneralCode GCProfileNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("ItemMasterIncentive")]
    public virtual Item Item { get; set; } = null!;
}
