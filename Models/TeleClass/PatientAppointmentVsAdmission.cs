using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "ActivityNo", "ActivityDateTime")]
public partial class PatientAppointmentVsAdmission
{
    [StringLength(50)]
    [Unicode(false)]
    public string ServiceUnitCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ServiceUnitName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ParamedicID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string PhysicianName { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string PatientName { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ActivityNo { get; set; } = null!;

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime ActivityDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }
}
