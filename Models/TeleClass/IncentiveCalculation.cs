using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ProcessDate", "TransactionNo", "SquenceNo")]
public partial class IncentiveCalculation
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime ProcessDate { get; set; }

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SquenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeNo { get; set; } = null!;

    public int Item { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCProfile { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Amount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }

    [ForeignKey("TransactionNo, SquenceNo")]
    [InverseProperty("IncentiveCalculation")]
    public virtual EmployeeRewardDt EmployeeRewardDt { get; set; } = null!;
}
