using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class VaccinationShotHd
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

    public int ParamedicID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime VaccinationDateTime { get; set; }

    public int? ServiceUnitId { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsSelected { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ParamedicID")]
    [InverseProperty("VaccinationShotHd")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("VaccinationShotHd")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("VaccinationShotHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [InverseProperty("VaccinationShotHd")]
    public virtual ICollection<VaccinationShotSubDt> VaccinationShotSubDt { get; set; } = new List<VaccinationShotSubDt>();
}
