using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class CompoundTemplateHd
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string TemplateCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string TemplateName { get; set; } = null!;

    public int? ParamedicId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SignaQty { get; set; }

    public byte? SignaFrequency { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AdministrationTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCFrequency { get; set; }

    public byte? Duration { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? DispenseQty { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? ConsumeMethod { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? EmbalaceId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCRoute { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDrugType { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsSweetener { get; set; }

    public bool IsActive { get; set; }

    public bool IsReviewed { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("TemplateCodeNavigation")]
    public virtual ICollection<CompoundTemplateDt> CompoundTemplateDt { get; set; } = new List<CompoundTemplateDt>();

    [ForeignKey("EmbalaceId")]
    [InverseProperty("CompoundTemplateHd")]
    public virtual EmbalaceHd? Embalace { get; set; }

    [ForeignKey("GCDrugType")]
    [InverseProperty("CompoundTemplateHdGCDrugTypeNavigation")]
    public virtual sysGeneralCode? GCDrugTypeNavigation { get; set; }

    [ForeignKey("GCFrequency")]
    [InverseProperty("CompoundTemplateHdGCFrequencyNavigation")]
    public virtual sysGeneralCode? GCFrequencyNavigation { get; set; }

    [ForeignKey("GCRoute")]
    [InverseProperty("CompoundTemplateHdGCRouteNavigation")]
    public virtual sysGeneralCode? GCRouteNavigation { get; set; }

    [ForeignKey("ParamedicId")]
    [InverseProperty("CompoundTemplateHd")]
    public virtual Paramedic? Paramedic { get; set; }
}
