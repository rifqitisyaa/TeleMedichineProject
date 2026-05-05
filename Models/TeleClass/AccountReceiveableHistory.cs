using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ARNo", "BusinessPartnerId", "RegistrationNo")]
public partial class AccountReceiveableHistory
{
    public DateOnly ARDate { get; set; }

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ARNo { get; set; } = null!;

    [Key]
    public int BusinessPartnerId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string BusinessPartnerName { get; set; } = null!;

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string GCCustomerType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CustomerName { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BalanceAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal SalesAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PaymentAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }
}
