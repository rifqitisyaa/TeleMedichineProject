using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("TemplateId", "SequenceNo")]
public partial class PrescriptionTemplateDt
{
    [Key]
    public int TemplateId { get; set; }

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Dose { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string Frequency { get; set; } = null!;

    public byte Duration { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? DispenseQty { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSigna { get; set; }

    public byte? SignaFrequency { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ConsumeUnit { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SignaQty { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? ConsumeMethod { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool? IsCompound { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? ResultQty { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ParentID { get; set; }

    public bool? IsSweetener { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? EmbalaceID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CompoundQty { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCRoute { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCOrderType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDrugType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AdministrationTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCFrequency { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? RFlag { get; set; }

    public bool IsByDosage { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("EmbalaceID")]
    [InverseProperty("PrescriptionTemplateDt")]
    public virtual EmbalaceHd? Embalace { get; set; }

    [ForeignKey("GCDrugType")]
    [InverseProperty("PrescriptionTemplateDtGCDrugTypeNavigation")]
    public virtual sysGeneralCode? GCDrugTypeNavigation { get; set; }

    [ForeignKey("GCFrequency")]
    [InverseProperty("PrescriptionTemplateDtGCFrequencyNavigation")]
    public virtual sysGeneralCode? GCFrequencyNavigation { get; set; }

    [ForeignKey("GCOrderType")]
    [InverseProperty("PrescriptionTemplateDtGCOrderTypeNavigation")]
    public virtual sysGeneralCode? GCOrderTypeNavigation { get; set; }

    [ForeignKey("GCRoute")]
    [InverseProperty("PrescriptionTemplateDtGCRouteNavigation")]
    public virtual sysGeneralCode? GCRouteNavigation { get; set; }

    [ForeignKey("GCSigna")]
    [InverseProperty("PrescriptionTemplateDtGCSignaNavigation")]
    public virtual sysGeneralCode? GCSignaNavigation { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("PrescriptionTemplateDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("TemplateId")]
    [InverseProperty("PrescriptionTemplateDt")]
    public virtual PrescriptionTemplateHd Template { get; set; } = null!;
}
