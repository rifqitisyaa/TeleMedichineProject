using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("DownPaymentNo", "ReferenceNo")]
public partial class DownPaymentDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DownPaymentNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ReferenceNo { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lastUpdatedDateTime { get; set; }

    [ForeignKey("DownPaymentNo")]
    [InverseProperty("DownPaymentDt")]
    public virtual DownPaymentHd DownPaymentNoNavigation { get; set; } = null!;
}
