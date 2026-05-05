using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Allergen
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string AllergenID { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCAllergenType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string AllergenName { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCAllergenType")]
    [InverseProperty("Allergen")]
    public virtual sysGeneralCode GCAllergenTypeNavigation { get; set; } = null!;
}
