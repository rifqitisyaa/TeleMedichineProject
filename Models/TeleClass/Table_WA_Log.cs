using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Table_WA_Log
{
    [Key]
    public int LogId { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? LogKey { get; set; }

    public int? InstanceId { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Job_id { get; set; }

    public int? ContactId { get; set; }

    [Unicode(false)]
    public string? MessageText { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ScheduledTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SentStatus { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
