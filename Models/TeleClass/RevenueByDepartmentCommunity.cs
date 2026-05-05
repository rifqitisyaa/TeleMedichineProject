using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "DepartmentCode", "CommunityId", "MedicalNo", "TransactionDate")]
public partial class RevenueByDepartmentCommunity
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string DepartmentName { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string CommunityId { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CommunityName { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string PatientName { get; set; } = null!;

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
