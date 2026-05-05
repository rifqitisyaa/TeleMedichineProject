using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_InvoicePayment
{
    [StringLength(20)]
    [Unicode(false)]
    public string? InvoiceNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PaymentNo { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? PaymentAmount { get; set; }
}
