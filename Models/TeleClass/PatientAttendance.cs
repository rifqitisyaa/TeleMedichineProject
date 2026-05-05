using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PatientAttendance
{
    [Key]
    public long AttendanceID { get; set; }

    public int? ParamedicID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AttendanceDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ReferenceNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string PatientName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSex { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    public int? ServiceUnitID { get; set; }

    public int? RoomID { get; set; }

    public byte VisitDuration { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? VisitTypeCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    public int StatusID { get; set; }

    public bool IsRegistration { get; set; }

    public bool IsAttend { get; set; }

    public bool? IsNotAttend { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }

    [ForeignKey("GCSex")]
    [InverseProperty("PatientAttendance")]
    public virtual sysGeneralCode? GCSexNavigation { get; set; }

    [ForeignKey("ParamedicID")]
    [InverseProperty("PatientAttendance")]
    public virtual Paramedic? Paramedic { get; set; }

    [ForeignKey("RoomID")]
    [InverseProperty("PatientAttendance")]
    public virtual ServiceRoom? Room { get; set; }

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("PatientAttendance")]
    public virtual DepartmentServiceUnit? ServiceUnit { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("PatientAttendance")]
    public virtual Site? SiteCodeNavigation { get; set; }

    [ForeignKey("StatusID")]
    [InverseProperty("PatientAttendance")]
    public virtual StatusPriority Status { get; set; } = null!;

    [ForeignKey("VisitTypeCode")]
    [InverseProperty("PatientAttendance")]
    public virtual VisitType? VisitTypeCodeNavigation { get; set; }
}
