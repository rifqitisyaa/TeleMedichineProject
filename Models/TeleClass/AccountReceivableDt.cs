using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ARNo", "ARAccrualNo")]
public partial class AccountReceivableDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ARNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ARAccrualNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ARAccrualNo")]
    [InverseProperty("AccountReceivableDt")]
    public virtual AccountReceivableAccrual ARAccrualNoNavigation { get; set; } = null!;

    [ForeignKey("ARNo")]
    [InverseProperty("AccountReceivableDt")]
    public virtual AccountReceivableHd ARNoNavigation { get; set; } = null!;
}
