using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("GCMostFrequentType", "L1", "L2", "L3", "ItemID")]
public partial class ItemMostFrequent
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCMostFrequentType { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string L1 { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string L2 { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string L3 { get; set; } = null!;

    [Key]
    public int ItemID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCMostFrequentType")]
    [InverseProperty("ItemMostFrequent")]
    public virtual sysGeneralCode GCMostFrequentTypeNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("ItemMostFrequent")]
    public virtual Item Item { get; set; } = null!;
}
