using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("Code", "ReferenceCode")]
public partial class KfaIngredients
{
    [Key]
    [StringLength(255)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? Display { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? KfaRemarks { get; set; }

    [Key]
    public int ReferenceCode { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ReferenceRemarks { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
