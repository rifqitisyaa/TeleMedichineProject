using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tmpAccountReceivableHistoryByPeriod
{
    [StringLength(6)]
    [Unicode(false)]
    public string Period { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ARNo { get; set; } = null!;

    public DateOnly ARDate { get; set; }

    public int BusinessPartnerId { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal ARAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PaymentAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal OutstandingAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }
}
