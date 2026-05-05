using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TemplateText
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string TemplateCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string TemplateName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCTemplateGroup { get; set; }

    [Unicode(false)]
    public string? TemplateContent { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? L1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? L2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? L3 { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCTemplateGroup")]
    [InverseProperty("TemplateText")]
    public virtual sysGeneralCode? GCTemplateGroupNavigation { get; set; }
}
