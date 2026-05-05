using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BrandCode", "GenericID")]
public partial class ItemBrandGeneric
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

    [ForeignKey("BrandCode")]
    [InverseProperty("ItemBrandGeneric")]
    public virtual ItemBrand BrandCodeNavigation { get; set; } = null!;

    [ForeignKey("DosageUnitCode")]
    [InverseProperty("ItemBrandGeneric")]
    public virtual ItemUnit? DosageUnitCodeNavigation { get; set; }

    [ForeignKey("GenericID")]
    [InverseProperty("ItemBrandGeneric")]
    public virtual ItemGeneric Generic { get; set; } = null!;
}
