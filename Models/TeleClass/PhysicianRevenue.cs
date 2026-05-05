using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class PhysicianRevenue
{
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string PatientName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ServiceUnitName { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string ParamedicName { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TarifRS { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? drg { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? JSDOK { get; set; }

    public DateOnly? ARDate { get; set; }

    public int ParamedicID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? ARReverseAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? Lab { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? Rad { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? OBAT { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? BHP { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CrossMargin { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal? CrossMarginPercent { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DepartmentName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ClassName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? JmlVisit { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? JSOP { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? JSANASTESI { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? JSAsAnastesi { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NamaJSOP { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NamaJSANASTESI { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NamaJSAsANASTESI { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegistrationDateTime { get; set; }

    public bool IsOT { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? COB { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? NaikKelas { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? drgName { get; set; }

    [Column(TypeName = "numeric(3, 0)")]
    public decimal? LOSInDay { get; set; }
}
