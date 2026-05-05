using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ROPNo", "SequenceNo", "DetailNo")]
public partial class ROPHistoryDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ROPNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string DetailNo { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QtyProcess { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
