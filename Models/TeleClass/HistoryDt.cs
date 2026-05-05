using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class HistoryDt
{
    [StringLength(20)]
    [Unicode(false)]
    public string? JobOrderNo { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? SequenceNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [Unicode(false)]
    public string? ItemName { get; set; }

    [Unicode(false)]
    public string? ResultValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Unit { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? NormalValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Indicator { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResultDateTime { get; set; }
}
