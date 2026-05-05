using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class CHDBloodPressure
{
    [Key]
    public int CHDBloodPressureID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCSex { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCSystolicValue { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCDiastolicValue { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCCHDBloodPressureValue { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCCHDBloodPressureValue")]
    [InverseProperty("CHDBloodPressureGCCHDBloodPressureValueNavigation")]
    public virtual sysGeneralCode GCCHDBloodPressureValueNavigation { get; set; } = null!;

    [ForeignKey("GCDiastolicValue")]
    [InverseProperty("CHDBloodPressureGCDiastolicValueNavigation")]
    public virtual sysGeneralCode GCDiastolicValueNavigation { get; set; } = null!;

    [ForeignKey("GCSex")]
    [InverseProperty("CHDBloodPressureGCSexNavigation")]
    public virtual sysGeneralCode GCSexNavigation { get; set; } = null!;

    [ForeignKey("GCSystolicValue")]
    [InverseProperty("CHDBloodPressureGCSystolicValueNavigation")]
    public virtual sysGeneralCode GCSystolicValueNavigation { get; set; } = null!;
}
