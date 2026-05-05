using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class _mims_ItemDrug
{
    [Key]
    public Guid ReferenceID { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ItemName { get; set; }

    public Guid? ItemBrandReferenceID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DrugFormCode { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal? Dosage { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DosageUnitCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCRoute { get; set; }

    public bool? IsFormulariumItem { get; set; }

    public bool? IsGenericDrug { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? HETAmount { get; set; }
}
