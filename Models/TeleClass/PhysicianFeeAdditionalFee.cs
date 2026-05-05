using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PhysicianFeeAdditionalFee
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string VerificationNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TransactionDate { get; set; }

    [Unicode(false)]
    public string Description { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TransactionAmount { get; set; }

    public bool? IsCalculateGuaranteeFee { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("VerificationNo")]
    [InverseProperty("PhysicianFeeAdditionalFee")]
    public virtual PhysicianFeeVerification VerificationNoNavigation { get; set; } = null!;
}
