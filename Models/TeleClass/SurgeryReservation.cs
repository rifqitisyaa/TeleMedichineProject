using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SurgeryReservation
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ReservationNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string WorkStationCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string CategoryCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ReservationDateTime { get; set; }

    public int Duration { get; set; }

    public int ParamedicID { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("CategoryCode")]
    [InverseProperty("SurgeryReservation")]
    public virtual SurgeryCategory CategoryCodeNavigation { get; set; } = null!;

    [ForeignKey("ParamedicID")]
    [InverseProperty("SurgeryReservation")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [InverseProperty("ReservationNoNavigation")]
    public virtual ICollection<PatientSurgeryStatus> PatientSurgeryStatus { get; set; } = new List<PatientSurgeryStatus>();

    [InverseProperty("ReservationNoNavigation")]
    public virtual ICollection<PhysicianTeamSurgery> PhysicianTeamSurgery { get; set; } = new List<PhysicianTeamSurgery>();

    [ForeignKey("RegistrationNo")]
    [InverseProperty("SurgeryReservation")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("SurgeryReservation")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("SurgeryReservation")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;

    [ForeignKey("WorkStationCode")]
    [InverseProperty("SurgeryReservation")]
    public virtual WorkStation WorkStationCodeNavigation { get; set; } = null!;
}
