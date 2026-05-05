using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class EmergencyContact
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ContactName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCRelationship { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string MobilePhoneNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? PhoneNo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCOccupation { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CompanyName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? CompanyAddress { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Notes { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCOccupation")]
    [InverseProperty("EmergencyContactGCOccupationNavigation")]
    public virtual sysGeneralCode? GCOccupationNavigation { get; set; }

    [ForeignKey("GCRelationship")]
    [InverseProperty("EmergencyContactGCRelationshipNavigation")]
    public virtual sysGeneralCode GCRelationshipNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("EmergencyContact")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
