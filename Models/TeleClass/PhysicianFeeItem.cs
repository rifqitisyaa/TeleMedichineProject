using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("TransactionNo", "SequenceNo")]
public partial class PhysicianFeeItem
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ParamedicID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal FeeAmount { get; set; }

    public DateOnly TransactionDate { get; set; }

    public DateOnly ProcessDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VerificationNo { get; set; }

    public bool IsConfirm { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ParamedicID")]
    [InverseProperty("PhysicianFeeItem")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PhysicianFeeItem")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("VerificationNo")]
    [InverseProperty("PhysicianFeeItem")]
    public virtual PhysicianFeeVerification? VerificationNoNavigation { get; set; }
}
