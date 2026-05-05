using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("TransactionNo", "SequenceNo")]
public partial class TransactionChargesDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string? FromSequenceNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ReferenceSequenceNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceCorrectionTransactionNo { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ReferenceCorrectionSequenceNo { get; set; }

    public int? LocationID { get; set; }

    public int ItemID { get; set; }

    public int? ParamedicID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ChargesQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal DispenseQty { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemUnitCode { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ConversionFactor { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal LaborCost { get; set; }

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
    public decimal CustomerCitoCompPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PersonalCitoCompPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PpnCustomer { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PpnPersonal { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalCustomer { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalPersonal { get; set; }

    public bool IsFromRecalculation { get; set; }

    public bool IsFromTransactionCorrection { get; set; }

    public bool IsVariable { get; set; }

    public bool IsCito { get; set; }

    public bool IsComplication { get; set; }

    public bool IsAssetUtilization { get; set; }

    public bool IsShow { get; set; }

    public bool? IsVerifiedRevenue { get; set; }

    public int? AssetID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? FromRegistrationNo { get; set; }

    public DateOnly? ExpiredDate { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDiscontinued { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("AssetID")]
    [InverseProperty("TransactionChargesDt")]
    public virtual Assets? Asset { get; set; }

    [InverseProperty("TransactionChargesDt")]
    public virtual ICollection<DebitNoteCreditNoteDt> DebitNoteCreditNoteDt { get; set; } = new List<DebitNoteCreditNoteDt>();

    [ForeignKey("FromRegistrationNo")]
    [InverseProperty("TransactionChargesDt")]
    public virtual Registration? FromRegistrationNoNavigation { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("TransactionChargesDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ItemUnitCode")]
    [InverseProperty("TransactionChargesDt")]
    public virtual ItemUnit ItemUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("LocationID")]
    [InverseProperty("TransactionChargesDt")]
    public virtual Location? Location { get; set; }

    [ForeignKey("ParamedicID")]
    [InverseProperty("TransactionChargesDt")]
    public virtual Paramedic? Paramedic { get; set; }

    [InverseProperty("TransactionChargesDt")]
    public virtual ICollection<RecalculationDt> RecalculationDt { get; set; } = new List<RecalculationDt>();

    [InverseProperty("TransactionChargesDt")]
    public virtual ICollection<RecalculationDtBom> RecalculationDtBom { get; set; } = new List<RecalculationDtBom>();

    [InverseProperty("TransactionChargesDt")]
    public virtual ICollection<TransactionChargesDtBOM> TransactionChargesDtBOM { get; set; } = new List<TransactionChargesDtBOM>();

    [ForeignKey("TransactionNo")]
    [InverseProperty("TransactionChargesDt")]
    public virtual TransactionChargesHd TransactionNoNavigation { get; set; } = null!;
}
