using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ClassCode", "ParamedicID")]
public partial class PhysicianChargesByClass
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    [Key]
    public int ParamedicID { get; set; }

    public int ItemId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ClassCode")]
    [InverseProperty("PhysicianChargesByClass")]
    public virtual Class ClassCodeNavigation { get; set; } = null!;

    [ForeignKey("ItemId")]
    [InverseProperty("PhysicianChargesByClass")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ParamedicID")]
    [InverseProperty("PhysicianChargesByClass")]
    public virtual Paramedic Paramedic { get; set; } = null!;
}
