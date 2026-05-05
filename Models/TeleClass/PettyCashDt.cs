using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ReimburseNo", "SequenceNo")]
public partial class PettyCashDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ReimburseNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string BSNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime BSDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BSAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
