using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PatientResponsibleLog
{
    [Key]
    public long LogID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public int? OriginPhyisicianID { get; set; }

    public int? OriginNurseID { get; set; }

    public int? ResponsiblePhysicianID { get; set; }

    public int? ResponsibleNurseID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string UserID { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LogDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("OriginNurseID")]
    [InverseProperty("PatientResponsibleLogOriginNurse")]
    public virtual Paramedic? OriginNurse { get; set; }

    [ForeignKey("OriginPhyisicianID")]
    [InverseProperty("PatientResponsibleLogOriginPhyisician")]
    public virtual Paramedic? OriginPhyisician { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PatientResponsibleLog")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("ResponsibleNurseID")]
    [InverseProperty("PatientResponsibleLogResponsibleNurse")]
    public virtual Paramedic? ResponsibleNurse { get; set; }

    [ForeignKey("ResponsiblePhysicianID")]
    [InverseProperty("PatientResponsibleLogResponsiblePhysician")]
    public virtual Paramedic? ResponsiblePhysician { get; set; }
}
