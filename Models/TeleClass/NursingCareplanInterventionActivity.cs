using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NursingCareplanInterventionActivity
{
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

    [StringLength(20)]
    [Unicode(false)]
    public string NicActivityCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Rationale { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("NicActivityCode")]
    [InverseProperty("NursingCareplanInterventionActivity")]
    public virtual NicActivity NicActivityCodeNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo, NursingCareplanNo, NursingCareplanInterventionNo")]
    [InverseProperty("NursingCareplanInterventionActivity")]
    public virtual NursingCareplanIntervention NursingCareplanIntervention { get; set; } = null!;
}
