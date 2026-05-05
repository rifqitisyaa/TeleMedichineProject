using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class RuleLabDashboard
{
    [Key]
    public int RuleId { get; set; }

    public int? ItemId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ParameterName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Temuan { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Sex { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? MinVal { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? MaxVal { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Operator { get; set; }
}
