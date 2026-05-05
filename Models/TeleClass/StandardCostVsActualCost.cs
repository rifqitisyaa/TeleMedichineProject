using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("CostType", "CoaCode")]
public partial class StandardCostVsActualCost
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string CostType { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string CoaCode { get; set; } = null!;

    public bool IsStandardCost { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("CoaCode")]
    [InverseProperty("StandardCostVsActualCost")]
    public virtual ChartOfAccount CoaCodeNavigation { get; set; } = null!;

    [ForeignKey("CostType")]
    [InverseProperty("StandardCostVsActualCost")]
    public virtual sysGeneralCode CostTypeNavigation { get; set; } = null!;
}
