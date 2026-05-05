using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("DetailId", "RegistrationNo", "NursingCareplanNo", "NursingCareplanOutcomeNo")]
public partial class NsNursingCareplanOutcome
{
    [Key]
    public long DetailId { get; set; }

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

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DetailId")]
    [InverseProperty("NsNursingCareplanOutcome")]
    public virtual NurseShiftTransferHistoryDt Detail { get; set; } = null!;
}
