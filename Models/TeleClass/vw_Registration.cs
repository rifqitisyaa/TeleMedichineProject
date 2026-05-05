using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_Registration
{
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RegistrationDateTime { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    public int ServiceUnitID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ServiceUnitName { get; set; } = null!;

    public int? BedID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? BedCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ClassCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ClassName { get; set; }

    public bool IsDischarge { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DischargeDateTime { get; set; }

    [Column(TypeName = "numeric(38, 4)")]
    public decimal? TransactionAmount { get; set; }

    public int? ParamedicID { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? ParamedicName { get; set; }

    public bool IsClosed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClosedDateTime { get; set; }
}
