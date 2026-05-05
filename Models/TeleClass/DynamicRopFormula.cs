using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DynamicRopFormula
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string FormulaCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string FormulaName { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string MinValueFormula { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string MaxValueFormula { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
