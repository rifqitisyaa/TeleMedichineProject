using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NocIndicator
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string NocIndicatorCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string NocIndicatorName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string NocCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string NocScaleCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("NocCode")]
    [InverseProperty("NocIndicator")]
    public virtual Noc NocCodeNavigation { get; set; } = null!;

    [ForeignKey("NocScaleCode")]
    [InverseProperty("NocIndicator")]
    public virtual NocScale NocScaleCodeNavigation { get; set; } = null!;

    [InverseProperty("NocIndicatorCodeNavigation")]
    public virtual ICollection<NursingCareplanOutcomeResult> NursingCareplanOutcomeResult { get; set; } = new List<NursingCareplanOutcomeResult>();
}
