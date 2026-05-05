using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("AllergenID", "KfaCode")]
public partial class AllergenKfa
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string AllergenID { get; set; } = null!;

    [Key]
    public int KfaCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? KfaName { get; set; }

    [StringLength(501)]
    [Unicode(false)]
    public string? AllergenName { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
