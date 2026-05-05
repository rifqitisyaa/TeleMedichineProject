using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("VitalSignVs3", "VitalSignCode")]
public partial class VitalSignCodeVs3
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string VitalSignVs3 { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string VitalSignCode { get; set; } = null!;

    public bool? IsAutoCharge { get; set; }

    public int? ItemService { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemService")]
    [InverseProperty("VitalSignCodeVs3")]
    public virtual Item? ItemServiceNavigation { get; set; }

    [ForeignKey("VitalSignCode")]
    [InverseProperty("VitalSignCodeVs3")]
    public virtual VitalSignType VitalSignCodeNavigation { get; set; } = null!;
}
