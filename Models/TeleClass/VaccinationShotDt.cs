using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo", "DetailSubNo", "DetailNo")]
public partial class VaccinationShotDt
{
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
    public string DetailSubNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string DetailNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string VaccinationTypeCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCVaccinationStatus { get; set; }

    public DateOnly? DateOnVIS { get; set; }

    public DateOnly? DateVISGiven { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCVaccinationStatus")]
    [InverseProperty("VaccinationShotDt")]
    public virtual sysGeneralCode? GCVaccinationStatusNavigation { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("VaccinationShotDt")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo, SequenceNo, DetailSubNo")]
    [InverseProperty("VaccinationShotDt")]
    public virtual VaccinationShotSubDt VaccinationShotSubDt { get; set; } = null!;

    [ForeignKey("VaccinationTypeCode")]
    [InverseProperty("VaccinationShotDt")]
    public virtual VaccinationType VaccinationTypeCodeNavigation { get; set; } = null!;
}
