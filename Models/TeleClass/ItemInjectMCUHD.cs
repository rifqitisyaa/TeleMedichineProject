using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class ItemInjectMCUHD
{
    [StringLength(512)]
    [Unicode(false)]
    public string? ItemCompileCode { get; set; }

    [Unicode(false)]
    public string? ItemCompileName { get; set; }

    [Unicode(false)]
    public string? ItemCompileName2 { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? GCCompileType { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? ParentCode { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsHeader { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsActive { get; set; }

    public int? Remarks { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsNormal { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsDeleted { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? LastUpdatedDatetime { get; set; }
}
