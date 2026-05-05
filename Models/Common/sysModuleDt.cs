using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[PrimaryKey("GroupRoleCode", "ModuleID")]
public partial class sysModuleDt
{
    [Key]
    [StringLength(50)]
    public string GroupRoleCode { get; set; } = null!;

    [Key]
    [StringLength(10)]
    public string ModuleID { get; set; } = null!;

    [StringLength(100)]
    public string ModuleName { get; set; } = null!;

    [StringLength(35)]
    public string ModuleShortName { get; set; } = null!;

    public byte ModuleIndex { get; set; }

    [StringLength(255)]
    public string ImageUrl { get; set; } = null!;

    [StringLength(255)]
    public string DisabledImageUrl { get; set; } = null!;

    [StringLength(255)]
    public string DefaultUrl { get; set; } = null!;

    [StringLength(255)]
    public string? HelpUrl { get; set; }

    [StringLength(255)]
    public string LogoutUrl { get; set; } = null!;

    [StringLength(50)]
    public string ToolTip { get; set; } = null!;

    [StringLength(500)]
    public string Remarks { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }
}
