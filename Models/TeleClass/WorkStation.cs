using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class WorkStation
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string WorkStationCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string WorkStationName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCWorkCenter { get; set; } = null!;

    public int? ReferenceID { get; set; }

    public int? ParamedicID { get; set; }

    public int? RoomID { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal MaximumLoad { get; set; }

    public byte FixOrderFence { get; set; }

    public byte? OverlapQuantity { get; set; }

    public byte? Recall { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("WorkStationCodeNavigation")]
    public virtual ICollection<Appointment> Appointment { get; set; } = new List<Appointment>();

    [InverseProperty("WorkStationCodeNavigation")]
    public virtual ICollection<CalenderDt> CalenderDt { get; set; } = new List<CalenderDt>();

    [ForeignKey("GCWorkCenter")]
    [InverseProperty("WorkStation")]
    public virtual sysGeneralCode GCWorkCenterNavigation { get; set; } = null!;

    [ForeignKey("ParamedicID")]
    [InverseProperty("WorkStation")]
    public virtual Paramedic? Paramedic { get; set; }

    [InverseProperty("WorkStationCodeNavigation")]
    public virtual ICollection<Registration> Registration { get; set; } = new List<Registration>();

    [ForeignKey("RoomID")]
    [InverseProperty("WorkStation")]
    public virtual ServiceRoom? Room { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("WorkStation")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [InverseProperty("WorkStationCodeNavigation")]
    public virtual ICollection<SurgeryReservation> SurgeryReservation { get; set; } = new List<SurgeryReservation>();
}
