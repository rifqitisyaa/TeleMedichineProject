using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("JobOrderNo", "SequenceNo")]
public partial class JobOrderDtMedication
{
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

    [Column(TypeName = "numeric(10, 2)")]
    public decimal TakenQtyDummy { get; set; }

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

    public bool IsDischargePrescription { get; set; }

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

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? PersonalPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CustomerPrice { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCInstruction { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCBud { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpiredDate { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Indication { get; set; }

    public bool? byDosageButton { get; set; }

    public bool? byQuantityButton { get; set; }

    public bool IsByDosage { get; set; }

    public bool? IsDrugAlert { get; set; }

    public bool? IsDrugInteraction { get; set; }

    public bool IsAutopack { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    public bool? IsChanged { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ChangeName { get; set; }

    public bool? isResulted { get; set; }

    public bool? IsSent { get; set; }

    [ForeignKey("ConsumeUnit")]
    [InverseProperty("JobOrderDtMedication")]
    public virtual ItemUnit? ConsumeUnitNavigation { get; set; }

    [InverseProperty("JobOrderDtMedication")]
    public virtual ICollection<DrugAdministration> DrugAdministration { get; set; } = new List<DrugAdministration>();

    [ForeignKey("EmbalaceID")]
    [InverseProperty("JobOrderDtMedication")]
    public virtual EmbalaceHd? Embalace { get; set; }

    [ForeignKey("GCDrugType")]
    [InverseProperty("JobOrderDtMedicationGCDrugTypeNavigation")]
    public virtual sysGeneralCode? GCDrugTypeNavigation { get; set; }

    [ForeignKey("GCFrequency")]
    [InverseProperty("JobOrderDtMedicationGCFrequencyNavigation")]
    public virtual sysGeneralCode? GCFrequencyNavigation { get; set; }

    [ForeignKey("GCMedicationType")]
    [InverseProperty("JobOrderDtMedicationGCMedicationTypeNavigation")]
    public virtual sysGeneralCode? GCMedicationTypeNavigation { get; set; }

    [ForeignKey("GCOrderType")]
    [InverseProperty("JobOrderDtMedicationGCOrderTypeNavigation")]
    public virtual sysGeneralCode? GCOrderTypeNavigation { get; set; }

    [ForeignKey("GCRoute")]
    [InverseProperty("JobOrderDtMedicationGCRouteNavigation")]
    public virtual sysGeneralCode? GCRouteNavigation { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("JobOrderDtMedication")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("JobOrderNo")]
    [InverseProperty("JobOrderDtMedication")]
    public virtual JobOrderHd JobOrderNoNavigation { get; set; } = null!;

    [ForeignKey("ParamedicID")]
    [InverseProperty("JobOrderDtMedication")]
    public virtual Paramedic? Paramedic { get; set; }
}
