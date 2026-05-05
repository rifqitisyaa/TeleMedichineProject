using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("FromLocationID", "ToLocationID")]
public partial class DistributionOrderLocationTemplate
{
    [Key]
    public int FromLocationID { get; set; }

    [Key]
    public int ToLocationID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("FromLocationID")]
    [InverseProperty("DistributionOrderLocationTemplateFromLocation")]
    public virtual Location FromLocation { get; set; } = null!;

    [ForeignKey("ToLocationID")]
    [InverseProperty("DistributionOrderLocationTemplateToLocation")]
    public virtual Location ToLocation { get; set; } = null!;
}
