using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class PaymentRefundMedicationDt
{
    [StringLength(20)]
    [Unicode(false)]
    public string PaymentRefundNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ReferenceNo { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal ReferanceAmount { get; set; }

    public bool? IsDeleted { get; set; }
}
