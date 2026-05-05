using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NandaRiskFactor
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string NandaRiskFactorCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string NandaRiskFactorName { get; set; } = null!;

    [Unicode(false)]
    public string? NandaRiskFactorName2 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string NandaRiskFactorGroupCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string NandaCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("NandaCode")]
    [InverseProperty("NandaRiskFactor")]
    public virtual Nanda NandaCodeNavigation { get; set; } = null!;

    [ForeignKey("NandaRiskFactorGroupCode")]
    [InverseProperty("NandaRiskFactor")]
    public virtual NandaRiskFactorGroup NandaRiskFactorGroupCodeNavigation { get; set; } = null!;

    [InverseProperty("NandaRiskFactorCodeNavigation")]
    public virtual ICollection<NursingCareplanRiskFactor> NursingCareplanRiskFactor { get; set; } = new List<NursingCareplanRiskFactor>();
}
