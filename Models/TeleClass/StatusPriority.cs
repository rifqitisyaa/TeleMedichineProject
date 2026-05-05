using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class StatusPriority
{
    [Key]
    public int StatusID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string StatusName { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Priority { get; set; } = null!;

    public bool IsAppointmentStatus { get; set; }

    public bool IsRegistrationStatus { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Status")]
    public virtual ICollection<Appointment> Appointment { get; set; } = new List<Appointment>();

    [InverseProperty("Status")]
    public virtual ICollection<PatientAttendance> PatientAttendance { get; set; } = new List<PatientAttendance>();

    [InverseProperty("Status")]
    public virtual ICollection<Registration> Registration { get; set; } = new List<Registration>();
}
