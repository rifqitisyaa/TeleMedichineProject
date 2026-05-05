using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("AllergenID", "SctCode")]
public partial class AllergenSct
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string AllergenID { get; set; } = null!;

    [Key]
    public int SctCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? SctName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? AllergenName { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
