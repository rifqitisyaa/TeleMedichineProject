using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("TransactionName", "ReferenceNo", "VoidDateTime")]
public partial class VoidTransaction
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string TransactionName { get; set; } = null!;

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string ReferenceNo { get; set; } = null!;

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime VoidDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string VoidBy { get; set; } = null!;

    [Unicode(false)]
    public string VoidReason { get; set; } = null!;

    [Unicode(false)]
    public string? Remarks { get; set; }
}
