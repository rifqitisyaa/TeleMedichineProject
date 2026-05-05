using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DaySubstitute
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string EmployeeId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ScheduleDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ScheduleShiftCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime SubstituteDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SubstituteShiftCode { get; set; } = null!;

    [Unicode(false)]
    public string Description { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? PreparedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    public bool IsApproved { get; set; }

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

    [ForeignKey("EmployeeId")]
    [InverseProperty("DaySubstitute")]
    public virtual Employee Employee { get; set; } = null!;

    [ForeignKey("ScheduleShiftCode")]
    [InverseProperty("DaySubstituteScheduleShiftCodeNavigation")]
    public virtual WorkShiftHrd ScheduleShiftCodeNavigation { get; set; } = null!;

    [ForeignKey("SubstituteShiftCode")]
    [InverseProperty("DaySubstituteSubstituteShiftCodeNavigation")]
    public virtual WorkShiftHrd SubstituteShiftCodeNavigation { get; set; } = null!;
}
