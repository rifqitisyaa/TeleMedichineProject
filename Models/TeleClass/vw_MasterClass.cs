using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_MasterClass
{
    [StringLength(10)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ClassName { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string ShortName { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string Initial { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ClassCategoryName { get; set; } = null!;

    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsActiveClassCategory { get; set; }

    public bool IsDeletedClassCategory { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedByClassCategory { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTimeClassCategory { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? GeneralCodeName1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? GeneralCodeName2 { get; set; }

    public byte ClassLevel { get; set; }

    public bool IsAdministrationChargeByClass { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MinAdministrationCharge { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MaxAdministrationCharge { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal PercentageAdministrationCharge { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PhysicianChargesItemCode { get; set; }

    public bool IsActiveClass { get; set; }

    public bool IsDeletedClass { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
