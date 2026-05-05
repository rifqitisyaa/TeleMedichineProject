using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class _mims_Product_bak
{
    public Guid ProductID { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ProductName { get; set; }

    public Guid? ProductLineID { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ProductLineName { get; set; }

    public Guid? DrugFormID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? DrugFormName { get; set; }

    public Guid? RouteID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? RouteName { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Dosage { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DosageUnit { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ATCCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ATCName { get; set; }

    public Guid? CompanyID { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? CompanyName { get; set; }
}
