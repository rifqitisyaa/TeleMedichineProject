using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class OvertimeWorkOrder
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string WorkOrderNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime WorkOrderDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    public bool IsByDuration { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ShiftCode { get; set; } = null!;

    [Unicode(false)]
    public string WorkOrderDescription { get; set; } = null!;

    public bool? IsBeforeDutyOn { get; set; }

    public int? BdoDurationHour { get; set; }

    public int? BdoDurationMinute { get; set; }

    public int? BdoDurationBreakHour { get; set; }

    public int? BdoDurationBreakDurationMinute { get; set; }

    public bool? IsAfterDutyOn { get; set; }

    public int? AdoDurationHour { get; set; }

    public int? AdoDurationMinute { get; set; }

    public int? AdoDurationBreakHour { get; set; }

    public int? AdoDurationBreakMinute { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? BdoSPLTime { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? BdoSPLBreakHour { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? BdoSPLBreakMinute { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? AdoSPLTime { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? AdoBreakHour { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? AdoBreakMinute { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    public int? OvertimeCategory1 { get; set; }

    public int? OvertimeCategory2 { get; set; }

    public int? OvertimeCategory3 { get; set; }

    public bool? IsApproved { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("WorkOrderNoNavigation")]
    public virtual ICollection<OvertimeWorkOrderDt> OvertimeWorkOrderDt { get; set; } = new List<OvertimeWorkOrderDt>();

    [ForeignKey("ShiftCode")]
    [InverseProperty("OvertimeWorkOrder")]
    public virtual WorkShiftHrd ShiftCodeNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("OvertimeWorkOrder")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("OvertimeWorkOrder")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
