using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class _imp_mims_ItemDrug
{
    [Key]
    public int ItemID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? BrandCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DrugFormCode { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal Dosage { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DosageUnitCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCRoute { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCNarkotika { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDrugType { get; set; }

    public bool IsFormulariumItem { get; set; }

    public bool IsGenericDrug { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? HETAmount { get; set; }

    public bool IsNewItem { get; set; }

    public Guid? MimsReferenceID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
