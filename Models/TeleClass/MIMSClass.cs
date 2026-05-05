using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MIMSClass
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MIMSClassCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string MIMSClassName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? ParentCode { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("ParentCodeNavigation")]
    public virtual ICollection<MIMSClass> InverseParentCodeNavigation { get; set; } = new List<MIMSClass>();

    [InverseProperty("MIMSClassCodeNavigation")]
    public virtual ICollection<ItemBrand> ItemBrand { get; set; } = new List<ItemBrand>();

    [ForeignKey("ParentCode")]
    [InverseProperty("InverseParentCodeNavigation")]
    public virtual MIMSClass? ParentCodeNavigation { get; set; }
}
