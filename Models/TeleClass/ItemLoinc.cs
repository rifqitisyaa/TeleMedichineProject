using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ItemID", "LoincCode")]
public partial class ItemLoinc
{
    [Key]
    public int ItemID { get; set; }

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string LoincCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? LoincName { get; set; }

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
