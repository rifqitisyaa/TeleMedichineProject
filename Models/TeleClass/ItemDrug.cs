using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ItemDrug
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

    public bool? IsPrekursor { get; set; }

    public bool? IsOOT { get; set; }

    public bool? IsNarkotikaPsikotropika { get; set; }

    public bool? IsHighAlert { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? HETAmount { get; set; }

    public bool IsNewItem { get; set; }

    public bool? IsAllowRoundUp { get; set; }

    public bool IsAutopackItem { get; set; }

    public Guid? MimsReferenceID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DefaultConsumeUnit { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BrandCode")]
    [InverseProperty("ItemDrug")]
    public virtual ItemBrand? BrandCodeNavigation { get; set; }

    [ForeignKey("DefaultConsumeUnit")]
    [InverseProperty("ItemDrugDefaultConsumeUnitNavigation")]
    public virtual ItemUnit? DefaultConsumeUnitNavigation { get; set; }

    [ForeignKey("DosageUnitCode")]
    [InverseProperty("ItemDrugDosageUnitCodeNavigation")]
    public virtual ItemUnit DosageUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("DrugFormCode")]
    [InverseProperty("ItemDrugDrugFormCodeNavigation")]
    public virtual ItemUnit? DrugFormCodeNavigation { get; set; }

    [ForeignKey("GCDrugType")]
    [InverseProperty("ItemDrugGCDrugTypeNavigation")]
    public virtual sysGeneralCode? GCDrugTypeNavigation { get; set; }

    [ForeignKey("GCNarkotika")]
    [InverseProperty("ItemDrugGCNarkotikaNavigation")]
    public virtual sysGeneralCode? GCNarkotikaNavigation { get; set; }

    [ForeignKey("GCRoute")]
    [InverseProperty("ItemDrugGCRouteNavigation")]
    public virtual sysGeneralCode? GCRouteNavigation { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("ItemDrug")]
    public virtual Item Item { get; set; } = null!;
}
