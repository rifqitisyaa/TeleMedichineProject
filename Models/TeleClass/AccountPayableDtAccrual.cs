using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("APNo", "APAccrualNo")]
public partial class AccountPayableDtAccrual
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string APNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string APAccrualNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("APAccrualNo")]
    [InverseProperty("AccountPayableDtAccrual")]
    public virtual AccountPayableAccrual APAccrualNoNavigation { get; set; } = null!;

    [ForeignKey("APNo")]
    [InverseProperty("AccountPayableDtAccrual")]
    public virtual AccountPayableHd APNoNavigation { get; set; } = null!;
}
