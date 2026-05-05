using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("No", "JenisTindakan")]
public partial class ItemMasterLaboratory
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string No { get; set; } = null!;

    [Key]
    [StringLength(500)]
    [Unicode(false)]
    public string JenisTindakan { get; set; } = null!;

    [Unicode(false)]
    public string? ItemID { get; set; }

    public int? NoUrut { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
