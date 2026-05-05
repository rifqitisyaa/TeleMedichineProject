using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PhysicianTeamSurgery
{
    [Key]
    public int SurgeryTeamID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ReservationNo { get; set; } = null!;

    public int ParamedicID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCSurgeryParamedicType { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? SurgeryTeamCode { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCSurgeryParamedicType")]
    [InverseProperty("PhysicianTeamSurgery")]
    public virtual sysGeneralCode GCSurgeryParamedicTypeNavigation { get; set; } = null!;

    [ForeignKey("ParamedicID")]
    [InverseProperty("PhysicianTeamSurgery")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [ForeignKey("ReservationNo")]
    [InverseProperty("PhysicianTeamSurgery")]
    public virtual SurgeryReservation ReservationNoNavigation { get; set; } = null!;

    [ForeignKey("SurgeryTeamCode")]
    [InverseProperty("PhysicianTeamSurgery")]
    public virtual SurgeryTeamTemplateHd? SurgeryTeamCodeNavigation { get; set; }
}
