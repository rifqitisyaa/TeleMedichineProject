using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ItemDrugDisplay
{
    [Key]
    public long ItemID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemName1 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemGroupCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string BaseUnitCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string BaseUnitName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string BrandCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string BrandName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? DosageUnitCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DosageUnitShortName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DosageUnitName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DrugFormName { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Dosage { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCRoute { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RouteName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDrugType { get; set; }

    [Unicode(false)]
    public string? Generic { get; set; }

    [Unicode(false)]
    public string? GenericName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DefaultConsumeUnit { get; set; }

    public Guid? MimsReferenceID { get; set; }

    public bool? IsAllowRoundUp { get; set; }

    public bool IsAutopackItem { get; set; }

    public bool? IsFormulariumItem { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
