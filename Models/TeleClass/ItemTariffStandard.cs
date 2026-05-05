using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "GCMember", "DocumentNo", "ItemID", "ClassCategoryCode")]
public partial class ItemTariffStandard
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCMember { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DocumentNo { get; set; } = null!;

    [Key]
    public int ItemID { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ClassCategoryCode { get; set; } = null!;

    public byte? RevisionNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DocumentDate { get; set; }

    public DateOnly StartingDate { get; set; }

    public DateOnly EndingDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal StandardPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CustomerPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PersonalPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DiscountPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MinVariablePrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MaxVariablePrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? StandardPriceBefore { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CustomerPriceBefore { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? PersonalPriceBefore { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DiscountPriceBefore { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ClassCategoryCode")]
    [InverseProperty("ItemTariffStandard")]
    public virtual ClassCategory ClassCategoryCodeNavigation { get; set; } = null!;

    [ForeignKey("GCMember")]
    [InverseProperty("ItemTariffStandard")]
    public virtual sysGeneralCode GCMemberNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("ItemTariffStandard")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("ItemTariffStandard")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
