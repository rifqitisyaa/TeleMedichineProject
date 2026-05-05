using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class CHDRisk
{
    [Key]
    public int CHDRiskID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCSex { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string CHDType { get; set; } = null!;

    public int PtsValue { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CHDRiskValue { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCSex")]
    [InverseProperty("CHDRisk")]
    public virtual sysGeneralCode GCSexNavigation { get; set; } = null!;
}
