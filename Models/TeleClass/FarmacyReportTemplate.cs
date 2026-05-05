using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class FarmacyReportTemplate
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string RecordCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? No { get; set; }

    [Unicode(false)]
    public string? Activity { get; set; }

    [Unicode(false)]
    public string? Description { get; set; }

    [Unicode(false)]
    public string? DefaultValue { get; set; }

    [Unicode(false)]
    public string? OrderNo { get; set; }

    [Unicode(false)]
    public string? CustomQuery { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }
}
