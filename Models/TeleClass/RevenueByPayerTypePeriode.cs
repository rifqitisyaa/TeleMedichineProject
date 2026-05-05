using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("TransactionDate", "RegistrationNo", "GCItemType")]
public partial class RevenueByPayerTypePeriode
{
    [StringLength(50)]
    [Unicode(false)]
    public string GCCustomerType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string PayerType { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string BusinessPartnerID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Payer { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string DepartmentName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ServiceUnitCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ServiceUnitName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string PatientName { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RegistrationDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DischargeDateTime { get; set; }

    public int? LOS { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string GCItemType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemType { get; set; } = null!;

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime TransactionDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Amount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }
}
