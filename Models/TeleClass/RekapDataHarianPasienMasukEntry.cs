using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class RekapDataHarianPasienMasukEntry
{
    [Column(TypeName = "datetime")]
    public DateTime? Tanggal { get; set; }

    public int? PerempuanIGDSuspect { get; set; }

    public int? LakiLakiIGDSuspect { get; set; }

    public int? PerempuanIGDConfirm { get; set; }

    public int? LakiLakiIGDConfirm { get; set; }

    public int? PerempuanRawatJalanSuspect { get; set; }

    public int? LakiLakiRawatJalanSuspect { get; set; }

    public int? PerempuanRawatJalanConfirm { get; set; }

    public int? LakiLakiRawatJalanConfirm { get; set; }

    public int? PerempuanRawatInapSuspect { get; set; }

    public int? LakiLakiRawatInapSuspect { get; set; }

    public int? PerempuanRawatInapConfirm { get; set; }

    public int? LakiLakiRawatInapConfirm { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalLapor { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
