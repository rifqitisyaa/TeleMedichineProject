using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Nanda
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string NandaCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string NandaDiagnosis { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? NandaDiagnosis2 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string NandaDefinition { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string NandaClassCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("NandaCodeNavigation")]
    public virtual ICollection<NandaCharacteristic> NandaCharacteristic { get; set; } = new List<NandaCharacteristic>();

    [InverseProperty("NandaCodeNavigation")]
    public virtual ICollection<NandaNicAdditional> NandaNicAdditional { get; set; } = new List<NandaNicAdditional>();

    [InverseProperty("NandaCodeNavigation")]
    public virtual ICollection<NandaNicPriority> NandaNicPriority { get; set; } = new List<NandaNicPriority>();

    [InverseProperty("NandaCodeNavigation")]
    public virtual ICollection<NandaNicSuggested> NandaNicSuggested { get; set; } = new List<NandaNicSuggested>();

    [InverseProperty("NandaCodeNavigation")]
    public virtual ICollection<NandaNocAdditional> NandaNocAdditional { get; set; } = new List<NandaNocAdditional>();

    [InverseProperty("NandaCodeNavigation")]
    public virtual ICollection<NandaNocSuggested> NandaNocSuggested { get; set; } = new List<NandaNocSuggested>();

    [InverseProperty("NandaCodeNavigation")]
    public virtual ICollection<NandaRelatedFactor> NandaRelatedFactor { get; set; } = new List<NandaRelatedFactor>();

    [InverseProperty("NandaCodeNavigation")]
    public virtual ICollection<NandaRiskFactor> NandaRiskFactor { get; set; } = new List<NandaRiskFactor>();

    [InverseProperty("NandaCodeNavigation")]
    public virtual ICollection<NandaTemplateDt> NandaTemplateDt { get; set; } = new List<NandaTemplateDt>();

    [InverseProperty("NandaCodeNavigation")]
    public virtual ICollection<NursingCareplan> NursingCareplan { get; set; } = new List<NursingCareplan>();
}
