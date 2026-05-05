using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("TransactionNo", "SquenceNo")]
public partial class EmployeeRewardDt
{
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
    public string TreatmentNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TreatmentSquenceNo { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("EmployeeRewardDt")]
    public virtual ICollection<IncentiveCalculation> IncentiveCalculation { get; set; } = new List<IncentiveCalculation>();
}
