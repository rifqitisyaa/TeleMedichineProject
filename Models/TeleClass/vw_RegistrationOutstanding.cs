using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_RegistrationOutstanding
{
    [StringLength(100)]
    [Unicode(false)]
    public string PatientType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RegistrationDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string DepartmentName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ServiceUnitName { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string ParamedicName { get; set; } = null!;

    [Column(TypeName = "numeric(38, 4)")]
    public decimal TotalTransaction { get; set; }

    [Column(TypeName = "numeric(38, 4)")]
    public decimal TotalPayment { get; set; }

    [Column(TypeName = "numeric(38, 4)")]
    public decimal? Outstanding { get; set; }

    public bool IsDischarge { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DischargeDateTime { get; set; }

    public bool IsClosed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClosedDateTime { get; set; }
}
