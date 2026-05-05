using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "RegistrationNo")]
public partial class MedicalRecordLog
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ServiceUnitID { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? CheckoutTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CheckinTime { get; set; }

    public bool IsIn { get; set; }

    public bool IsOut { get; set; }

    [StringLength(75)]
    [Unicode(false)]
    public string? CheckoutUser { get; set; }

    [StringLength(75)]
    [Unicode(false)]
    public string? CheckinUser { get; set; }

    public bool IsDeleted { get; set; }

    public bool? IsConfirm { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
