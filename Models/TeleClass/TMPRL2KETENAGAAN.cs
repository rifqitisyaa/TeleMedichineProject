using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class TMPRL2KETENAGAAN
{
    [Column("KODE RS")]
    public double? KODE_RS { get; set; }

    [Column("KAB/KOTA")]
    [StringLength(255)]
    public string? KAB_KOTA { get; set; }

    [Column("KODE PROPINSI")]
    [StringLength(53)]
    public string? KODE_PROPINSI { get; set; }

    [Column("NAMA RS")]
    [StringLength(255)]
    public string? NAMA_RS { get; set; }

    public double? TAHUN { get; set; }

    public double? NoUrut { get; set; }

    public double? NO { get; set; }

    [Column("KUALIFIKASI PENDIDIKAN")]
    [StringLength(255)]
    public string? KUALIFIKASI_PENDIDIKAN { get; set; }

    [Column("KEADAAN LAKI-LAKI")]
    public double? KEADAAN_LAKI_LAKI { get; set; }

    [Column("KEADAAN PEREMPUAN")]
    public double? KEADAAN_PEREMPUAN { get; set; }

    [Column("KEBUTUHAN LAKI-LAKI")]
    public double? KEBUTUHAN_LAKI_LAKI { get; set; }

    [Column("KEBUTUHAN PEREMPUAN")]
    public double? KEBUTUHAN_PEREMPUAN { get; set; }

    [Column("KEKURANGAN LAKI-LAKI")]
    public double? KEKURANGAN_LAKI_LAKI { get; set; }

    [Column("KEKURANGAN PEREMPUAN")]
    public double? KEKURANGAN_PEREMPUAN { get; set; }
}
