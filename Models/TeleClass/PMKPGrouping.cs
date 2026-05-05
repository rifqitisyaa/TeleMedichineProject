using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PMKPGrouping
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string GroupingCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Grouping { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Initial { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
