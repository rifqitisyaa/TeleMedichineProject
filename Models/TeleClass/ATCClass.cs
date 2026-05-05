using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ATCClass
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ATCClassCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ATCClassName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? ParentCode { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDate { get; set; }

    [InverseProperty("ParentCodeNavigation")]
    public virtual ICollection<ATCClass> InverseParentCodeNavigation { get; set; } = new List<ATCClass>();

    [InverseProperty("ATCClassCodeNavigation")]
    public virtual ICollection<ItemBrand> ItemBrand { get; set; } = new List<ItemBrand>();

    [ForeignKey("ParentCode")]
    [InverseProperty("InverseParentCodeNavigation")]
    public virtual ATCClass? ParentCodeNavigation { get; set; }
}
