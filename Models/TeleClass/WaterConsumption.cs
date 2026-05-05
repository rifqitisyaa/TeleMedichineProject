using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("NomorIDPelanggan", "SequenceNo")]
public partial class WaterConsumption
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string NomorIDPelanggan { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? RecordingDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string MeterLastMonth { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? MeterThisMonth { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TakenThisMonth { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WaterCondition { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TariffPerMonth { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TariffAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
