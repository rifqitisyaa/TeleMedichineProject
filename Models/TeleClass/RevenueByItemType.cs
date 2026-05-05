using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BusinessPartnerId", "TransactionDate", "ItemId", "RegistrationNo")]
public partial class RevenueByItemType
{
    [Key]
    public int BusinessPartnerId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string BusinessPartnerName { get; set; } = null!;

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime TransactionDate { get; set; }

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string PatientName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string GCCustomerType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string PayerName { get; set; } = null!;

    [Key]
    public int ItemId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ItemGroupCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string GCItemType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemGroup { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemName { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Amount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }
}
