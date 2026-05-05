using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("DetailId", "InterventionActivityID")]
public partial class NsNursingCareplanInterventionActivity
{
    [Key]
    public long DetailId { get; set; }

    [Key]
    public long InterventionActivityID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string NursingCareplanNo { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string NursingCareplanInterventionNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string NicActivityCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Rationale { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ReviewedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ReviewedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DetailId")]
    [InverseProperty("NsNursingCareplanInterventionActivity")]
    public virtual NurseShiftTransferHistoryDt Detail { get; set; } = null!;
}
