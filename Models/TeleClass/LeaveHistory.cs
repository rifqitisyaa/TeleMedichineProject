using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class LeaveHistory
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ReferenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StartLeaveDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndLeaveDate { get; set; }

    [Column(TypeName = "numeric(10, 0)")]
    public decimal LeaveTakenQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal LeaveBalanceQty { get; set; }

    public bool? IsApproved { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    public bool? IsRejected { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("EmployeeId, SequenceNo")]
    [InverseProperty("LeaveHistory")]
    public virtual EmployeeLeave EmployeeLeave { get; set; } = null!;
}
