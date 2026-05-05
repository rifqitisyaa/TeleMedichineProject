using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ProgressiveTaxRate
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal RangeStart { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal RangeEnd { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal TaxPercentage { get; set; }

    public bool IsHasTaxRegistrant { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
