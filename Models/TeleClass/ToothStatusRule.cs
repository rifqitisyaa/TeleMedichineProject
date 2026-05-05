using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("GCToothStatus", "ValidGCToothStatus")]
public partial class ToothStatusRule
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCToothStatus { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ValidGCToothStatus { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCToothStatus")]
    [InverseProperty("ToothStatusRuleGCToothStatusNavigation")]
    public virtual sysGeneralCode GCToothStatusNavigation { get; set; } = null!;

    [ForeignKey("ValidGCToothStatus")]
    [InverseProperty("ToothStatusRuleValidGCToothStatusNavigation")]
    public virtual sysGeneralCode ValidGCToothStatusNavigation { get; set; } = null!;
}
