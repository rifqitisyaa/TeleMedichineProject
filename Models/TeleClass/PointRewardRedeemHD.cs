using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PointRewardRedeemHD
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RedeemDatetime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string CustomerCatagoryCode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BeginingPointQty { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalRedeemPoint { get; set; }

    public bool? IsReviewed { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDatetime { get; set; }
}
