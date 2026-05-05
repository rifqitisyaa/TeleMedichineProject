using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class sysModule
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ModuleID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ModuleName { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string ModuleShortName { get; set; } = null!;

    public byte ModuleIndex { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string ImageUrl { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string DisabledImageUrl { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string DefaultUrl { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? HelpUrl { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ToolTip { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }
}
