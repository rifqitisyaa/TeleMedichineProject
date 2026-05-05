using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ItemBrandReferenceID", "ItemGenericReferenceID")]
public partial class _mims_ItemBrandGeneric
{
    [Key]
    public Guid ItemBrandReferenceID { get; set; }

    [Key]
    public Guid ItemGenericReferenceID { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Dosage { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DosageUnitCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
