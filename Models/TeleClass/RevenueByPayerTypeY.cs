using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BusinessPartnerID", "TransactionPeriod", "GCCustomerType", "ServiceUnitCode")]
public partial class RevenueByPayerTypeY
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string GCCustomerType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string PayerType { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string BusinessPartnerID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Payer { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ServiceUnitCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ServiceUnit { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string TransactionPeriod { get; set; } = null!;

    public int Visit { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Quantity { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal Amount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }
}
