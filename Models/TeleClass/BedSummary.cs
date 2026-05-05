using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class BedSummary
{
    [StringLength(100)]
    [Unicode(false)]
    public string? Tahun { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Bulan { get; set; }

    [Column("Service Unit")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Service_Unit { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Class { get; set; }

    public int? Jumlah { get; set; }
}
