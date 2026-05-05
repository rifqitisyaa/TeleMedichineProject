using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class CorporateInvoiceVerified
{
    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NoAR { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? InvoiceAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? VerifiedAmount { get; set; }
}
