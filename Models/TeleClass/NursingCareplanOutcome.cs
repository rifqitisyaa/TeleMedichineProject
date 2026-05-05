using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "NursingCareplanNo", "NursingCareplanOutcomeNo")]
public partial class NursingCareplanOutcome
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string NursingCareplanNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string NursingCareplanOutcomeNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string NocCode { get; set; } = null!;

    [Unicode(false)]
    public string? Notes { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("NocCode")]
    [InverseProperty("NursingCareplanOutcome")]
    public virtual Noc NocCodeNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo, NursingCareplanNo")]
    [InverseProperty("NursingCareplanOutcome")]
    public virtual NursingCareplan NursingCareplan { get; set; } = null!;

    [InverseProperty("NursingCareplanOutcome")]
    public virtual ICollection<NursingCareplanOutcomeResult> NursingCareplanOutcomeResult { get; set; } = new List<NursingCareplanOutcomeResult>();
}
