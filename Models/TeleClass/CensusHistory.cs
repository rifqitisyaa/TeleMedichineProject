using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "CensusDateTime", "RegistrationNo", "SequenceNo")]
public partial class CensusHistory
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime CensusDateTime { get; set; }

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ServiceUnitID { get; set; }

    public int RoomID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? SpecialityCode { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Status { get; set; }

    public bool IsDischarge { get; set; }

    public int? PatientStay { get; set; }

    public int? PatientIn { get; set; }

    public int? TransferOut { get; set; }

    public int? TransferIn { get; set; }

    public int? PatientOut { get; set; }

    public int? DeathBefore48 { get; set; }

    public int? DeathAfter48 { get; set; }

    public int? LOS { get; set; }

    [ForeignKey("ClassCode")]
    [InverseProperty("CensusHistory")]
    public virtual Class ClassCodeNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("CensusHistory")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("RoomID")]
    [InverseProperty("CensusHistory")]
    public virtual ServiceRoom Room { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("CensusHistory")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("CensusHistory")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("SpecialityCode")]
    [InverseProperty("CensusHistory")]
    public virtual Specialty? SpecialityCodeNavigation { get; set; }
}
