using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class sysMenu
{
    [Key]
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

    [StringLength(20)]
    [Unicode(false)]
    public string GCMenuType { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string MenuUrl { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? MenuUrlEntry { get; set; }

    public Guid? ReportServiceID { get; set; }

    public byte MenuLevel { get; set; }

    public int MenuIndex { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string MenuTooltip { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? MenuHeader { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string CRUDMode { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string ImageUrl { get; set; } = null!;

    public bool IsHeader { get; set; }

    public bool IsShownInMenu { get; set; }

    public bool IsAllowEntryMode { get; set; }

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

    [InverseProperty("Menu")]
    public virtual InformedConsent? InformedConsent { get; set; }

    [InverseProperty("Menu")]
    public virtual ICollection<sysMenuEntryMode> sysMenuEntryMode { get; set; } = new List<sysMenuEntryMode>();

    [InverseProperty("Menu")]
    public virtual ICollection<sysMenuFavorite> sysMenuFavorite { get; set; } = new List<sysMenuFavorite>();

    [InverseProperty("Menu")]
    public virtual ICollection<sysMenuInRole> sysMenuInRole { get; set; } = new List<sysMenuInRole>();

    [InverseProperty("Menu")]
    public virtual ICollection<sysMenuInUser> sysMenuInUser { get; set; } = new List<sysMenuInUser>();

    [InverseProperty("Menu")]
    public virtual sysReport? sysReport { get; set; }
}
