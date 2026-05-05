using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BrandCode", "GenericID")]
public partial class _imp_mims_ItemBrandGeneric
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string BrandCode { get; set; } = null!;

    [Key]
    public int GenericID { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
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
