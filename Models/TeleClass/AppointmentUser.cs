using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AppointmentUser
{
    [Key]
    public int UserId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PatientName { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? UserPassword { get; set; }

    public DateOnly? UserDOB { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UserPhoneNo { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SSN { get; set; }
}
