using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Noc
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string NocCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string NocDescription { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string NocDefinition { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string NocClassCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Expectation { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("NocCodeNavigation")]
    public virtual ICollection<NandaNocAdditional> NandaNocAdditional { get; set; } = new List<NandaNocAdditional>();

    [InverseProperty("NocCodeNavigation")]
    public virtual ICollection<NandaNocSuggested> NandaNocSuggested { get; set; } = new List<NandaNocSuggested>();

    [ForeignKey("NocClassCode")]
    [InverseProperty("Noc")]
    public virtual NocClass NocClassCodeNavigation { get; set; } = null!;

    [InverseProperty("NocCodeNavigation")]
    public virtual ICollection<NocIndicator> NocIndicator { get; set; } = new List<NocIndicator>();

    [InverseProperty("NocCodeNavigation")]
    public virtual ICollection<NursingCareplanOutcome> NursingCareplanOutcome { get; set; } = new List<NursingCareplanOutcome>();
}
