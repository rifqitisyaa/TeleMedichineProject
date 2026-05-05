using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tempAPDes
{
    public DateOnly? Tgl { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string APNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string BusinessPartnerName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string BusinessPartnerCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? SupplierInvoiceNo { get; set; }

    [Column(TypeName = "numeric(20, 4)")]
    public decimal? APAmount { get; set; }
}
