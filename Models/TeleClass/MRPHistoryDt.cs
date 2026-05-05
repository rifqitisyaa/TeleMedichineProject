using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MRPNo", "SequenceNo", "DetailNo")]
public partial class MRPHistoryDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string MRPNo { get; set; } = null!;

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

    [ForeignKey("MRPNo, SequenceNo")]
    [InverseProperty("MRPHistoryDt")]
    public virtual MRPHistorySubDt MRPHistorySubDt { get; set; } = null!;
}
