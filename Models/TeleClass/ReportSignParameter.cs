using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ReportSignParameter
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ReportID { get; set; } = null!;

    [Unicode(false)]
    public string? ReportName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string DefaultLabel { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string DefaultName { get; set; } = null!;

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDatetime { get; set; }
}
