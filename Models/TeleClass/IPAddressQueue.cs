using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class IPAddressQueue
{
    [Key]
    public int Id { get; set; }

    public int? OrderNumber { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string IpAddress { get; set; } = null!;

    public bool IsByParamedic { get; set; }

    public int? ParamedicId { get; set; }

    public int? ServiceUnitId { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string Initial { get; set; } = null!;

    [Unicode(false)]
    public string? Remark { get; set; }

    public int? DocumentId { get; set; }

    public bool IsEnabled { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DocumentId")]
    [InverseProperty("IPAddressQueue")]
    public virtual ImageDocument? Document { get; set; }

    [ForeignKey("ParamedicId")]
    [InverseProperty("IPAddressQueue")]
    public virtual Paramedic? Paramedic { get; set; }

    [ForeignKey("ServiceUnitId")]
    [InverseProperty("IPAddressQueue")]
    public virtual DepartmentServiceUnit? ServiceUnit { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("IPAddressQueue")]
    public virtual Site? SiteCodeNavigation { get; set; }
}
