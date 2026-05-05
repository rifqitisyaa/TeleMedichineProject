using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class RekapDataHarianPasienDirawatKomorBid
{
    [Column(TypeName = "datetime")]
    public DateTime? Tanggal { get; set; }

    public int? JmlNICUKhususCovid { get; set; }

    public int? LakiLakiNKCSuspect { get; set; }

    public int? PerempuanNKCSuspect { get; set; }

    public int? LakiLakiNKCConfirm { get; set; }

    public int? PerempuanNKCConfirm { get; set; }

    public int? JmlPICUKhususCovid { get; set; }

    public int? LakiLakiPKCSuspect { get; set; }

    public int? PerempuanPKCSuspect { get; set; }

    public int? LakiLakiPKCConfirm { get; set; }

    public int? PerempuanPKCConfirm { get; set; }

    public int? JmlICUTekananNegatifdenganVentilator { get; set; }

    public int? LakiLakiITNDVSuspect { get; set; }

    public int? PerempuanITNDVSuspect { get; set; }

    public int? LakiLakiITNDVConfirm { get; set; }

    public int? PerempuanITNDVConfirm { get; set; }

    public int? JmlICUTekananNegatiftanpaVentilator { get; set; }

    public int? LakiLakiITNtVSuspect { get; set; }

    public int? PerempuanITNtVSuspect { get; set; }

    public int? LakiLakiITNtVConfirm { get; set; }

    public int? PerempuanITNtVConfirm { get; set; }

    public int? JmlICUTanpaTekananNegatifDenganVentilator { get; set; }

    public int? LakiLakiITTNDVSuspect { get; set; }

    public int? PerempuanTTNDVSuspect { get; set; }

    public int? LakiLakiITTNDVConfirm { get; set; }

    public int? PerempuanTTNDVConfirm { get; set; }

    public int? JmlICUTanpaTekananNegatifTanpaVentilator { get; set; }

    public int? LakiLakiITTNTVSuspect { get; set; }

    public int? PerempuanITTNTVSuspect { get; set; }

    public int? LakiLakiITTNTVConfirm { get; set; }

    public int? PerempuanITTNTVConfirm { get; set; }

    public int? JmlIsolasiTekananNegatif { get; set; }

    public int? LakiLakiITNSuspect { get; set; }

    public int? PerempuanITNSuspect { get; set; }

    public int? LakiLakiITNConfirm { get; set; }

    public int? PerempuanITNConfirm { get; set; }

    public int? JmlIsolasiTanpaTekananNegatif { get; set; }

    public int? LakiLakiITTNSuspect { get; set; }

    public int? PerempuanITTNSuspect { get; set; }

    public int? LakiLakiITTNConfirm { get; set; }

    public int? PerempuanITTNConfirm { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalLapor { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
