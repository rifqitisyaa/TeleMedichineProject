using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class RekapDataHarianPasienTanpaDirawatKomorBid
{
    [Column(TypeName = "datetime")]
    public DateTime? Tanggal { get; set; }

    public int? JmlNICU { get; set; }

    public int? LNICUSus { get; set; }

    public int? PNICUSus { get; set; }

    public int? LNICUCon { get; set; }

    public int? PNICUCon { get; set; }

    public int? JmlPICU { get; set; }

    public int? LPICUSus { get; set; }

    public int? PPICUSus { get; set; }

    public int? LPICUCon { get; set; }

    public int? PPICUCon { get; set; }

    public int? JmlICUND { get; set; }

    public int? LTNDSus { get; set; }

    public int? PTNDSus { get; set; }

    public int? LTNDCon { get; set; }

    public int? PTNDCon { get; set; }

    public int? JmlICUNT { get; set; }

    public int? LTNTSus { get; set; }

    public int? PTNTSus { get; set; }

    public int? LTNTCon { get; set; }

    public int? PTNTCon { get; set; }

    public int? LTPDSus { get; set; }

    public int? PTPDSus { get; set; }

    public int? LTPDCon { get; set; }

    public int? PTPDCon { get; set; }

    public int? LTPTSus { get; set; }

    public int? PTPTSus { get; set; }

    public int? LTPTCon { get; set; }

    public int? PTPTCon { get; set; }

    public int? LIsoNSus { get; set; }

    public int? PIsoNSus { get; set; }

    public int? LIsoNCon { get; set; }

    public int? PIsoNCon { get; set; }

    public int? LIsoPSus { get; set; }

    public int? PIsoPSus { get; set; }

    public int? LIsoPCon { get; set; }

    public int? PIsoPCon { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalLapor { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
