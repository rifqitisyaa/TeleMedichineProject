using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ItemID", "SctCode")]
public partial class ItemSct
{
    [Key]
    public int ItemID { get; set; }

    [Key]
    public int SctCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? SctName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Category { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? JenisPanel { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
