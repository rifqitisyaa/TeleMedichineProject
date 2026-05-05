using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class METargetHd
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string TargetNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TargetDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCGroupIndicator { get; set; } = null!;

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

    [ForeignKey("GCGroupIndicator")]
    [InverseProperty("METargetHd")]
    public virtual sysGeneralCode GCGroupIndicatorNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("METargetHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("METargetHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
