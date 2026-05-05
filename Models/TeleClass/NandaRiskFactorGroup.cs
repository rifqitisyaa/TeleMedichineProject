using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NandaRiskFactorGroup
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string NandaRiskFactorGroupCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string NandaRiskFactorGroupName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("NandaRiskFactorGroupCodeNavigation")]
    public virtual ICollection<NandaRiskFactor> NandaRiskFactor { get; set; } = new List<NandaRiskFactor>();
}
