using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ReportDelivery
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DeliveryPlanDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDeliveryMethod { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDeliveryStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeliveryDateTime { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdateby { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }
}
