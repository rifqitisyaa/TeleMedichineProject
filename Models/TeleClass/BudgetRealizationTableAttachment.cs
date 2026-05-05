using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BudgetNo", "SequenceNo", "DetailNo")]
public partial class BudgetRealizationTableAttachment
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string BudgetNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int? ItemID { get; set; }

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string DetailNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? FileName { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? IdFile { get; set; }
}
