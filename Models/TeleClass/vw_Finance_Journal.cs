using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_Finance_Journal
{
    public long TransactionHistoryID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TransactionDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string VoucherNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode_Header { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string DepartmentCode_Header { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ServiceUnitCode_Detail { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LocationCode { get; set; }

    public int? itemID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemUnitCode { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Price { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    public DateOnly? ExpiredDate { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal QuantityChange { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal BeginingBalanceLocation { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal EndingBalanceLocation { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal BeginingBalanceSite { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal EndingBalanceSite { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ReferenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? ReferenceSequenceNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? BusinessPartnerCode { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TransactionAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CostAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MaterialCostPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal LaborCostPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal OverheadCostPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BurdenCostPrice { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal SubconCostPrice { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks_Header { get; set; }

    public bool IsPosting { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PostingBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PostingDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy_Header { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime_Header { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string? JournalSequenceNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ServiceUnitCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string COACode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DebitAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CreditAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GLReference { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
