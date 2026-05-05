using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class Dashboard
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string DashboardType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string HeaderText { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string DashboardControl { get; set; } = null!;

    [Column(TypeName = "decimal(10, 2)")]
    public decimal MinimizedWidth { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Minimizeheight { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string TileViewState { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
