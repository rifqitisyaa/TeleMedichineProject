using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("TransNo", "BGNo")]
[Index("BGNo", Name = "UQ__GiroList__C7B5862C118A17F2", IsUnique = true)]
public partial class GiroListDt
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string TransNo { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string BGNo { get; set; } = null!;

    public DateOnly? BGDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BGBank { get; set; }

    [Column(TypeName = "numeric(38, 0)")]
    public decimal? BGAmount { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Status { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReffNo { get; set; }

    /// <summary>
    /// Void Reason
    /// </summary>
    [StringLength(254)]
    [Unicode(false)]
    public string? VoidReason { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BGType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Receiver { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PayFor { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BGBankAccount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoidDate { get; set; }

    public DateOnly? ClearDate { get; set; }

    public bool? IsReconcile { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DueDate { get; set; }
}
