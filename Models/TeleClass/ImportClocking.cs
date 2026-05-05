using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ImportClocking
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ImportDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartClockingDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndClockingDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Import")]
    public virtual ICollection<EmployeeTimeAttendance> EmployeeTimeAttendance { get; set; } = new List<EmployeeTimeAttendance>();
}
