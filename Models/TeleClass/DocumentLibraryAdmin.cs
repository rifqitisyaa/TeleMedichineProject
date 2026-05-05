using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class DocumentLibraryAdmin
{
    [StringLength(512)]
    [Unicode(false)]
    public string? Id { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? Category { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? DocumentNo { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? Version { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? FileName { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? Remark { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsActive { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsDeleted { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? LastUpdatedDateTime { get; set; }
}
