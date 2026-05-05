using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("AssetID", "SOCompletionNo", "SOCompletionSequenceNo")]
public partial class AssetExpense
{
    [Key]
    public int AssetID { get; set; }

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string SOCompletionNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SOCompletionSequenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("SOCompletionNo, SOCompletionSequenceNo")]
    [InverseProperty("AssetExpense")]
    public virtual ServiceOrderDt ServiceOrderDt { get; set; } = null!;
}
