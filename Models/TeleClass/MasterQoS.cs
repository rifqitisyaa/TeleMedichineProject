using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MasterQoS
{
    [Key]
    public int DataID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ReportType { get; set; } = null!;

    public int Period { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string GroupName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string SequenceCode { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string IndicatorName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
