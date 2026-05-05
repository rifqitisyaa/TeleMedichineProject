using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class LeaveCashable
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LeaveCashableDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? LeaveSequenceNo { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal LeaveQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal LeaveAmount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string PayrollPeriod { get; set; } = null!;

    public bool IsProcess { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpadatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("LeaveCashable")]
    public virtual Employee Employee { get; set; } = null!;
}
