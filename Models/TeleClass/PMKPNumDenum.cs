using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("DataID", "TypeNumDenum")]
public partial class PMKPNumDenum
{
    [Key]
    public int DataID { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string TypeNumDenum { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Denum { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
