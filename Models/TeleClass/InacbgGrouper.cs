using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo", "GCGrouperTitle")]
public partial class InacbgGrouper
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCGrouperTitle { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? GrouperCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? GrouperName { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal GrouperAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CmgCode { get; set; }

    [StringLength(1000)]
    public string? DescriptionUpgradeClass { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? ChargeClassAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? CoverClassAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? UpgradeClassAmount { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? UpgradeVIPPercentAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCGrouperTitle")]
    [InverseProperty("InacbgGrouper")]
    public virtual sysGeneralCode GCGrouperTitleNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo, SequenceNo")]
    [InverseProperty("InacbgGrouper")]
    public virtual InacbgClaim InacbgClaim { get; set; } = null!;

    [InverseProperty("InacbgGrouper")]
    public virtual ICollection<InacbgSpecialCMG> InacbgSpecialCMG { get; set; } = new List<InacbgSpecialCMG>();
}
