using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class VisitType
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string VisitTypeCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string VisitTypeName { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public byte DefaultVisitDuration { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("VisitTypeCodeNavigation")]
    public virtual ICollection<Appointment> Appointment { get; set; } = new List<Appointment>();

    [InverseProperty("VisitTypeCodeNavigation")]
    public virtual ICollection<ParamedicVisitType> ParamedicVisitType { get; set; } = new List<ParamedicVisitType>();

    [InverseProperty("VisitTypeCodeNavigation")]
    public virtual ICollection<PatientAttendance> PatientAttendance { get; set; } = new List<PatientAttendance>();

    [InverseProperty("VisitTypeCodeNavigation")]
    public virtual ICollection<Registration> Registration { get; set; } = new List<Registration>();
}
