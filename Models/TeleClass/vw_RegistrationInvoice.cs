using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_RegistrationInvoice
{
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? InvoiceNo { get; set; }

    public int? BusinessPartnerID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BusinessPartnerName { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "numeric(19, 4)")]
    public decimal? Outstanding { get; set; }
}
