using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MobileMembership
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string UserName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSex { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCSex")]
    [InverseProperty("MobileMembership")]
    public virtual sysGeneralCode? GCSexNavigation { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("MobileMembership")]
    public virtual Patient? MedicalNoNavigation { get; set; }
}
