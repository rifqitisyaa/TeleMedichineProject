using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("DetailId", "JobOrderNo", "SequenceNo")]
public partial class NsJobOrderDtMedication
{
    [Key]
    public long DetailId { get; set; }

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCMedicationType { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Dose { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string Frequency { get; set; } = null!;

    public byte Duration { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDateTime { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Prescriber { get; set; } = null!;

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

    public bool IsAdministrationHere { get; set; }

    public bool IsSelectedAdministrationHere { get; set; }

    public bool IsPrescription { get; set; }

    public bool? IsCompound { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? ResultQty { get; set; }

    public int? ParamedicID { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ParentID { get; set; }

    public bool? IsSweetener { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? EmbalaceID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InstructionBy { get; set; }

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

    public bool? IsDrugAlert { get; set; }

    public bool? IsDrugInteraction { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DetailId")]
    [InverseProperty("NsJobOrderDtMedication")]
    public virtual NurseShiftTransferHistoryDt Detail { get; set; } = null!;
}
