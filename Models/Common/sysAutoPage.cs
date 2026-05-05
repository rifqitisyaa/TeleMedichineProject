using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class sysAutoPage
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string MenuID { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string EntityClassName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? EntityClassNameChild { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? LinkFieldName { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? LinkFieldNameChild { get; set; }

    public bool? IsListAllowGrouping { get; set; }

    public bool? IsStartupHideFilter { get; set; }

    public bool? IsStartupHideAudit { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? RelatedEntityClassName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
