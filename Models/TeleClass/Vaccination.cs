using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Vaccination
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string VaccinationCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string VaccinationName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string VaccinationType { get; set; } = null!;

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

    [InverseProperty("VaccinationCodeNavigation")]
    public virtual ICollection<ItemVaccination> ItemVaccination { get; set; } = new List<ItemVaccination>();

    [InverseProperty("VaccinationCodeNavigation")]
    public virtual ICollection<VaccinationShotSubDt> VaccinationShotSubDt { get; set; } = new List<VaccinationShotSubDt>();
}
