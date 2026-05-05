using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_Patient_TransactionCharges_Hero
{
    [StringLength(20)]
    [Unicode(false)]
    public string? TransactionNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionSource { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string SubTransactionCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TransactionDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransactionDatePrint { get; set; }

    public int ServiceUnitID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ServiceUnitCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RoomCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? BedCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ChargeClassCode { get; set; } = null!;

    public bool? IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    public bool IsFromCPOE { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? SequenceNo { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? FromSequenceNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ReferenceSequenceNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LocationCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ParamedicCode { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? ChargesQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? DispenseQty { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemUnitCode { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? ConversionFactor { get; set; }

    [Column(TypeName = "numeric(38, 6)")]
    public decimal? Revenue { get; set; }

    [Column(TypeName = "numeric(38, 6)")]
    public decimal DiscountPrice { get; set; }

    [Column(TypeName = "numeric(19, 4)")]
    public decimal TotalCustomer { get; set; }

    [Column(TypeName = "numeric(19, 4)")]
    public decimal TotalPersonal { get; set; }

    public bool? IsVariable { get; set; }

    public bool? IsDiscontinued { get; set; }

    public bool? IsComplication { get; set; }

    public bool? IsCito { get; set; }

    public bool? IsVerifiedRevenue { get; set; }

    public bool IsAccrualInvoice { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsPersonalInvoice { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsCorporateInvoice { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedByDetail { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTimeDetail { get; set; }
}
