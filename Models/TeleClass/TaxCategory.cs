using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TaxCategory
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string TaxCategoryCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TaxCategoryName { get; set; } = null!;

    [Column(TypeName = "numeric(6, 2)")]
    public decimal Tax { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("TaxCategoryCodeNavigation")]
    public virtual ICollection<ItemTax> ItemTax { get; set; } = new List<ItemTax>();
}
