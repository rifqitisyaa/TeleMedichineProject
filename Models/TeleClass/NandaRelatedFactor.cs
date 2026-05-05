using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NandaRelatedFactor
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string NandaRelatedFactorCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string NandaRelatedFactorName { get; set; } = null!;

    [Unicode(false)]
    public string? NandaRelatedFactorName2 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string NandaRelatedFactorGroupCode { get; set; } = null!;

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
    [InverseProperty("NandaRelatedFactor")]
    public virtual Nanda NandaCodeNavigation { get; set; } = null!;

    [ForeignKey("NandaRelatedFactorGroupCode")]
    [InverseProperty("NandaRelatedFactor")]
    public virtual NandaRelatedFactorGroup NandaRelatedFactorGroupCodeNavigation { get; set; } = null!;

    [InverseProperty("NandaRelatedFactorCodeNavigation")]
    public virtual ICollection<NursingCareplanRelatedFactor> NursingCareplanRelatedFactor { get; set; } = new List<NursingCareplanRelatedFactor>();
}
