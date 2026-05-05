using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class VitalSignHd
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

    [Column(TypeName = "datetime")]
    public DateTime VitalSignDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Examiner { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? JobOrderNo { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("JobOrderNo")]
    [InverseProperty("VitalSignHd")]
    public virtual JobOrderHd? JobOrderNoNavigation { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("VitalSignHd")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("VitalSignHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [InverseProperty("VitalSignHd")]
    public virtual ICollection<VitalSignDt> VitalSignDt { get; set; } = new List<VitalSignDt>();
}
