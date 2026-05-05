using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class IcuTemplate
{
    [Key]
    public int TemplateId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCTemplateType { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? ItemTemplateCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ItemTemplateName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool? IsFromVitalSignType { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCTemplateType")]
    [InverseProperty("IcuTemplate")]
    public virtual sysGeneralCode GCTemplateTypeNavigation { get; set; } = null!;
}
