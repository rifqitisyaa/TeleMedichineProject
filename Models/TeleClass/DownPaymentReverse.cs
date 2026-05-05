using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DownPaymentReverse
{
    [Key]
    public int ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DownPaymentNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? APNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? APAccrualNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? POReceiptNo { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? ReverseAmount { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("APAccrualNo")]
    [InverseProperty("DownPaymentReverse")]
    public virtual AccountPayableAccrual? APAccrualNoNavigation { get; set; }

    [ForeignKey("APNo")]
    [InverseProperty("DownPaymentReverse")]
    public virtual AccountPayableHd? APNoNavigation { get; set; }

    [ForeignKey("DownPaymentNo")]
    [InverseProperty("DownPaymentReverse")]
    public virtual DownPaymentHd? DownPaymentNoNavigation { get; set; }
}
