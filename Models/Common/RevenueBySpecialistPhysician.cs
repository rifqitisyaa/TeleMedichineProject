using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[PrimaryKey("RegistrationNo", "SpecialtyCode", "ParamedicID", "ServiceUnitCode", "TransactionDate")]
public partial class RevenueBySpecialistPhysician
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string SpecialtyCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string SpecialtyName { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ParamedicID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ParamedicName { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ServiceUnitCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ServiceUnitName { get; set; } = null!;

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime TransactionDate { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Quantity { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Amount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }
}
