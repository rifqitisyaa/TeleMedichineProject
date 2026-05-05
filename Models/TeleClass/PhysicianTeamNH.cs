using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class PhysicianTeamNH
{
    [StringLength(255)]
    public string? PhysicianTeamID { get; set; }

    [StringLength(255)]
    public string? RegistrationNo { get; set; }

    [StringLength(255)]
    public string? ParamedicID { get; set; }

    [StringLength(255)]
    public string? IsLeader { get; set; }

    [StringLength(255)]
    public string? IsAutoCharges { get; set; }

    [StringLength(255)]
    public string? StartingDate { get; set; }

    [StringLength(255)]
    public string? EndingDate { get; set; }

    [StringLength(255)]
    public string? ItemID { get; set; }

    [StringLength(255)]
    public string? GCPhysicianType { get; set; }

    [StringLength(255)]
    public string? GCPhysicianTeamType { get; set; }

    [StringLength(255)]
    public string? IsClosed { get; set; }

    [StringLength(255)]
    public string? IsDeleted { get; set; }

    [StringLength(255)]
    public string? LastUpdatedBy { get; set; }

    [StringLength(255)]
    public string? LastUpdatedDateTime { get; set; }
}
