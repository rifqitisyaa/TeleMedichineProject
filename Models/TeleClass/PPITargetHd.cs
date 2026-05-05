using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PPITargetHd
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string TargetNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TargetDate { get; set; }

    public int TargetYear { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("PPITargetHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("PPITargetHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
