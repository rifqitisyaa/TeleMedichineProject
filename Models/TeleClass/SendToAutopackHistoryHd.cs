using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SendToAutopackHistoryHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string SendToAutopackNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string SendToAutopackMethod { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SendToAutopackBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime SendToAutopackDateTime { get; set; }

    public bool IsPrinted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("SendToAutopackHistoryHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("SendToAutopackHistoryHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
