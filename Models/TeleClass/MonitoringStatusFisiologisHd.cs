using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "MedicalNo")]
public partial class MonitoringStatusFisiologisHd
{
    [Key]
    [StringLength(25)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Umur { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Alamat { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? JenisKasus { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
