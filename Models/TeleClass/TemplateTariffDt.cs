using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TemplateTariffDt
{
    [Key]
    public int Id { get; set; }

    public int ParentId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string DocumentNo { get; set; } = null!;

    public int ItemID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ClassCategoryCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 0)")]
    public decimal Qty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal StandardPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CustomerPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PersonalPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DiscountPrice { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ClassCategoryCode")]
    [InverseProperty("TemplateTariffDt")]
    public virtual ClassCategory ClassCategoryCodeNavigation { get; set; } = null!;

    [ForeignKey("ClassCode")]
    [InverseProperty("TemplateTariffDt")]
    public virtual Class ClassCodeNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("TemplateTariffDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ParentId")]
    [InverseProperty("TemplateTariffDt")]
    public virtual TemplateTariffHd Parent { get; set; } = null!;
}
