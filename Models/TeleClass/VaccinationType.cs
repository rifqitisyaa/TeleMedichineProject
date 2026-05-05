using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class VaccinationType
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string VaccinationTypeCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string VaccinationTypeName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCVaccinationGroup { get; set; } = null!;

    public byte DisplayOrder { get; set; }

    public int DisplayColor { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCVaccinationGroup")]
    [InverseProperty("VaccinationType")]
    public virtual sysGeneralCode GCVaccinationGroupNavigation { get; set; } = null!;

    [InverseProperty("VaccinationTypeCodeNavigation")]
    public virtual ICollection<PatientVaccination> PatientVaccination { get; set; } = new List<PatientVaccination>();

    [InverseProperty("VaccinationTypeCodeNavigation")]
    public virtual ICollection<VaccinationShotDt> VaccinationShotDt { get; set; } = new List<VaccinationShotDt>();
}
