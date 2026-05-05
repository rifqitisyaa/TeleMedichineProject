using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class BedHistory
{
    [Key]
    public long Id { get; set; }

    public int? BedId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCBedStatusOld { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCBedStatusNew { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationOld { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNew { get; set; }

    public bool? IsActiveOld { get; set; }

    public bool? IsActiveNew { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BedId")]
    [InverseProperty("BedHistory")]
    public virtual Bed? Bed { get; set; }

    [ForeignKey("GCBedStatusNew")]
    [InverseProperty("BedHistoryGCBedStatusNewNavigation")]
    public virtual sysGeneralCode? GCBedStatusNewNavigation { get; set; }

    [ForeignKey("GCBedStatusOld")]
    [InverseProperty("BedHistoryGCBedStatusOldNavigation")]
    public virtual sysGeneralCode? GCBedStatusOldNavigation { get; set; }

    [ForeignKey("RegistrationNew")]
    [InverseProperty("BedHistoryRegistrationNewNavigation")]
    public virtual Registration? RegistrationNewNavigation { get; set; }

    [ForeignKey("RegistrationOld")]
    [InverseProperty("BedHistoryRegistrationOldNavigation")]
    public virtual Registration? RegistrationOldNavigation { get; set; }
}
