using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class VisitReason
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string VisitReasonCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string VisitReasonName { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsEmergencyReason { get; set; }

    public bool IsOPHReason { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("VisitReasonCodeNavigation")]
    public virtual ICollection<Registration> Registration { get; set; } = new List<Registration>();
}
