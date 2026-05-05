using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("DrugDispensingNo", "SequenceNo")]
public partial class DrugDispensingDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DrugDispensingNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? ReferenceSequenceNo { get; set; }

    public int ItemID { get; set; }

    public int? LocationId { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Dose { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string Frequency { get; set; } = null!;

    public byte Duration { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? DispenseQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? TakenQty { get; set; }

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
    public string? Remark { get; set; }

    public bool? IsCompound { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? ResultQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? ReturnQty { get; set; }

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
    public string? GCDrugType { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? RFlag { get; set; }

    public bool IsByDosage { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CostPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal StandardPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CustomerPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PersonalPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DiscountPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PpnPersonalPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PpnCustomerPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PersonalAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CustomerAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCInstruction { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpiredDate { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Indication { get; set; }

    public bool IsAutopack { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ConsumeUnit")]
    [InverseProperty("DrugDispensingDt")]
    public virtual ItemUnit? ConsumeUnitNavigation { get; set; }

    [ForeignKey("DrugDispensingNo")]
    [InverseProperty("DrugDispensingDt")]
    public virtual DrugDispensingHd DrugDispensingNoNavigation { get; set; } = null!;

    [ForeignKey("EmbalaceID")]
    [InverseProperty("DrugDispensingDt")]
    public virtual EmbalaceHd? Embalace { get; set; }

    [ForeignKey("GCDrugType")]
    [InverseProperty("DrugDispensingDtGCDrugTypeNavigation")]
    public virtual sysGeneralCode? GCDrugTypeNavigation { get; set; }

    [ForeignKey("GCRoute")]
    [InverseProperty("DrugDispensingDtGCRouteNavigation")]
    public virtual sysGeneralCode? GCRouteNavigation { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("DrugDispensingDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("LocationId")]
    [InverseProperty("DrugDispensingDt")]
    public virtual Location? Location { get; set; }
}
