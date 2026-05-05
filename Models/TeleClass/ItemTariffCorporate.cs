using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "BusinessPartnerID", "DocumentNo", "ItemID", "ClassCategoryCode")]
public partial class ItemTariffCorporate
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    public int BusinessPartnerID { get; set; }

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

    [Column(TypeName = "datetime")]
    public DateTime StartingDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndingDate { get; set; }

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

    public bool? IsItemDiscountCorporateInvoice { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("ItemTariffCorporate")]
    public virtual Customer BusinessPartner { get; set; } = null!;

    [ForeignKey("ClassCategoryCode")]
    [InverseProperty("ItemTariffCorporate")]
    public virtual ClassCategory ClassCategoryCodeNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("ItemTariffCorporate")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("ItemTariffCorporate")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
