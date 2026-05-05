using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MRPHistoryHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string MRPNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime MRPDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("MRPNoNavigation")]
    public virtual ICollection<MRPHistorySubDt> MRPHistorySubDt { get; set; } = new List<MRPHistorySubDt>();

    [ForeignKey("SiteCode")]
    [InverseProperty("MRPHistoryHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("MRPHistoryHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
