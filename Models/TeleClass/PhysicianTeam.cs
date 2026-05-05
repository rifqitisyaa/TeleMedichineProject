using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PhysicianTeam
{
    [Key]
    public int PhysicianTeamID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public int ParamedicID { get; set; }

    public bool IsLeader { get; set; }

    public bool IsAutoCharges { get; set; }

    public DateOnly StartingDate { get; set; }

    public DateOnly? EndingDate { get; set; }

    public int? ItemID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCPhysicianType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCPhysicianTeamType { get; set; }

    public bool IsClosed { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }

    [ForeignKey("GCPhysicianType")]
    [InverseProperty("PhysicianTeam")]
    public virtual sysGeneralCode? GCPhysicianTypeNavigation { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("PhysicianTeam")]
    public virtual Item? Item { get; set; }

    [ForeignKey("ParamedicID")]
    [InverseProperty("PhysicianTeam")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PhysicianTeam")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
