using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("PaymentPlanNo", "BusinessPartnerID")]
public partial class ListofContraBS
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string PaymentPlanNo { get; set; } = null!;

    [Key]
    public int BusinessPartnerID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalAPAmount { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BSNo { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
