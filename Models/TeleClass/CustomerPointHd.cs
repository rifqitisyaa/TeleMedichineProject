using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class CustomerPointHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string CustomerCatagoryCode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TransactionAmount { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal TotalPointQty { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal RedeemPointQty { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal OutStandingPointQty { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDatetime { get; set; }
}
