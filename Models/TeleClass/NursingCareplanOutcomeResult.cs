using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NursingCareplanOutcomeResult
{
    [Key]
    public long OutcomeResultID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string NursingCareplanNo { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string NursingCareplanOutcomeNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string NocIndicatorCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Result { get; set; } = null!;

    [Unicode(false)]
    public string? Notes { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ReviewedBy { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("NocIndicatorCode")]
    [InverseProperty("NursingCareplanOutcomeResult")]
    public virtual NocIndicator NocIndicatorCodeNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo, NursingCareplanNo, NursingCareplanOutcomeNo")]
    [InverseProperty("NursingCareplanOutcomeResult")]
    public virtual NursingCareplanOutcome NursingCareplanOutcome { get; set; } = null!;
}
