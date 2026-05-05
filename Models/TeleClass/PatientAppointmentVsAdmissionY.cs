using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ServiceUnitCode", "ParamedicID", "MedicalNo", "ActivityPeriod")]
public partial class PatientAppointmentVsAdmissionY
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ServiceUnitCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ServiceUnitName { get; set; } = null!;

    [Key]
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

    public int Appointment { get; set; }

    public int Registration { get; set; }

    public int Cancel { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ActivityPeriod { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }
}
