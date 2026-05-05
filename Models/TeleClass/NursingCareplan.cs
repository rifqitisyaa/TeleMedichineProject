using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "NursingCareplanNo")]
public partial class NursingCareplan
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string NursingCareplanNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string NandaCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DateOnset { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? RationaleOverall { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateResolved { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ResolvedBy { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("NandaCode")]
    [InverseProperty("NursingCareplan")]
    public virtual Nanda NandaCodeNavigation { get; set; } = null!;

    [InverseProperty("NursingCareplan")]
    public virtual ICollection<NursingCareplanCharacteristic> NursingCareplanCharacteristic { get; set; } = new List<NursingCareplanCharacteristic>();

    [InverseProperty("NursingCareplan")]
    public virtual ICollection<NursingCareplanIntervention> NursingCareplanIntervention { get; set; } = new List<NursingCareplanIntervention>();

    [InverseProperty("NursingCareplan")]
    public virtual ICollection<NursingCareplanOutcome> NursingCareplanOutcome { get; set; } = new List<NursingCareplanOutcome>();

    [InverseProperty("NursingCareplan")]
    public virtual ICollection<NursingCareplanRelatedFactor> NursingCareplanRelatedFactor { get; set; } = new List<NursingCareplanRelatedFactor>();

    [InverseProperty("NursingCareplan")]
    public virtual ICollection<NursingCareplanRiskFactor> NursingCareplanRiskFactor { get; set; } = new List<NursingCareplanRiskFactor>();

    [ForeignKey("RegistrationNo")]
    [InverseProperty("NursingCareplan")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("NursingCareplan")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
