using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[Keyless]
public partial class temp_sysmenu
{
    [StringLength(10)]
    [Unicode(false)]
    public string MenuID { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ModuleID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string MenuCaption1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string MenuCaption2 { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string MenuUrl { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? MenuUrlEntry { get; set; }

    public byte MenuLevel { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string MenuIndex { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string MenuTooltip { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? MenuHeader { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string CRUDMode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? ExpandPanel { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string ImageUrl { get; set; } = null!;

    public bool IsHeader { get; set; }

    public bool IsShownInMenu { get; set; }

    public bool IsBeginGroup { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string HelpLinkID { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
