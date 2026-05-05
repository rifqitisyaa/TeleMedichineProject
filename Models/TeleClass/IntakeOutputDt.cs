using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo", "DetailNo")]
public partial class IntakeOutputDt
{
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string DetailNo { get; set; } = null!;

    public bool IsIntake { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCIntakeOutputType { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal IntakeOutputAmount { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCIntakeOutputType")]
    [InverseProperty("IntakeOutputDt")]
    public virtual sysGeneralCode? GCIntakeOutputTypeNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("IntakeOutputDt")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
