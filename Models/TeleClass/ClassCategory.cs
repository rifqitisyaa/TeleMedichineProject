using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ClassCategory
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ClassCategoryCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ClassCategoryName { get; set; } = null!;

    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("ClassCategoryCodeNavigation")]
    public virtual ICollection<Class> Class { get; set; } = new List<Class>();

    [InverseProperty("ClassCategoryCodeNavigation")]
    public virtual ICollection<ItemTariffCorporate> ItemTariffCorporate { get; set; } = new List<ItemTariffCorporate>();

    [InverseProperty("ClassCategoryCodeNavigation")]
    public virtual ICollection<ItemTariffStandard> ItemTariffStandard { get; set; } = new List<ItemTariffStandard>();

    [InverseProperty("ClassCategoryCodeNavigation")]
    public virtual ICollection<ItemTax> ItemTax { get; set; } = new List<ItemTax>();

    [InverseProperty("ClassCategoryCodeNavigation")]
    public virtual ICollection<MarkUpPrice> MarkUpPrice { get; set; } = new List<MarkUpPrice>();

    [InverseProperty("ClassCategoryCodeNavigation")]
    public virtual ICollection<PraProcessDt> PraProcessDt { get; set; } = new List<PraProcessDt>();

    [InverseProperty("ClassCategoryCodeNavigation")]
    public virtual ICollection<TemplateTariffDt> TemplateTariffDt { get; set; } = new List<TemplateTariffDt>();
}
