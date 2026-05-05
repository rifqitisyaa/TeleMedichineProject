using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "ItemID", "ClassCategoryCode")]
public partial class ItemTax
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    public int ItemID { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ClassCategoryCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TaxCategoryCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ClassCategoryCode")]
    [InverseProperty("ItemTax")]
    public virtual ClassCategory ClassCategoryCodeNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("ItemTax")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("ItemTax")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TaxCategoryCode")]
    [InverseProperty("ItemTax")]
    public virtual TaxCategory TaxCategoryCodeNavigation { get; set; } = null!;
}
