using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Specialty
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SpecialtyCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string SpecialtyName1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string SpecialtyName2 { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCSpecialtyGroup { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("FromSpecialtyCodeNavigation")]
    public virtual ICollection<BedTransfer> BedTransferFromSpecialtyCodeNavigation { get; set; } = new List<BedTransfer>();

    [InverseProperty("ToSpecialtyCodeNavigation")]
    public virtual ICollection<BedTransfer> BedTransferToSpecialtyCodeNavigation { get; set; } = new List<BedTransfer>();

    [InverseProperty("SpecialtyCodeNavigation")]
    public virtual ICollection<BodyPartSpecialty> BodyPartSpecialty { get; set; } = new List<BodyPartSpecialty>();

    [InverseProperty("SpecialityCodeNavigation")]
    public virtual ICollection<CensusHistory> CensusHistory { get; set; } = new List<CensusHistory>();

    [InverseProperty("SpecialtyCodeNavigation")]
    public virtual ICollection<EpisodeProcedure> EpisodeProcedure { get; set; } = new List<EpisodeProcedure>();

    [ForeignKey("GCSpecialtyGroup")]
    [InverseProperty("Specialty")]
    public virtual sysGeneralCode GCSpecialtyGroupNavigation { get; set; } = null!;

    [InverseProperty("SpecialtyCodeNavigation")]
    public virtual ICollection<Paramedic> Paramedic { get; set; } = new List<Paramedic>();

    [InverseProperty("OriginalSpecialtyCodeNavigation")]
    public virtual ICollection<Registration> RegistrationOriginalSpecialtyCodeNavigation { get; set; } = new List<Registration>();

    [InverseProperty("SpecialtyCodeNavigation")]
    public virtual ICollection<Registration> RegistrationSpecialtyCodeNavigation { get; set; } = new List<Registration>();

    [InverseProperty("SpecialtyCodeNavigation")]
    public virtual ICollection<SpecialtyVitalSign> SpecialtyVitalSign { get; set; } = new List<SpecialtyVitalSign>();

    [InverseProperty("SpecialtyCodeNavigation")]
    public virtual ICollection<VitalSignType> VitalSignType { get; set; } = new List<VitalSignType>();
}
