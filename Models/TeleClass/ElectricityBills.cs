using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("NomorIDPelanggan", "SequenceNo")]
public partial class ElectricityBills
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string NomorIDPelanggan { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? RecordingDateTime { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? LwbppValue { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? Wbp1Value { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? Wbp2Value { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? FactorValue { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? BiayaLWBP { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? BiayaWBP1 { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? BiayaWBP2 { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TarifTotalLWPB { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TarifTotalWBP1 { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TarifTotalWPB2 { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? PemakaianTotalLWBP { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? PemakaianTotalWBP1 { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? PemakaianTotalWBP2 { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }
}
