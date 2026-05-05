using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("TableName", Name = "IX_sysTable_TableName", IsUnique = true)]
public partial class sysTable
{
    [Key]
    public int TableID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string TableName { get; set; } = null!;

    [StringLength(1000)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public bool IsAudit { get; set; }

    public bool? IsStatistic { get; set; }

    public bool IsMaster { get; set; }

    [Unicode(false)]
    public string? StatisticNote { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
