using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class RekapDataHarianPasienKeluar
{
    [Column(TypeName = "datetime")]
    public DateTime? Tanggal { get; set; }

    public int? SembuhAPD { get; set; }

    public int? Meninggal { get; set; }

    public int? Discarded { get; set; }

    public int? DenganKomorbid1 { get; set; }

    public int? TanpaKomorbid1 { get; set; }

    public int? Usia06HariDK2 { get; set; }

    public int? Usia728HariDK2 { get; set; }

    public int? Usia291TahunDK2 { get; set; }

    public int? Usia14TahunDK2 { get; set; }

    public int? Usia518TahunDK2 { get; set; }

    public int? Usia1940TahunDK2 { get; set; }

    public int? Usia4160TahunDK2 { get; set; }

    public int? Usia60TahunDK2 { get; set; }

    public int? Usia06HariTK2 { get; set; }

    public int? Usia728HariTK2 { get; set; }

    public int? Usia291TahunTK2 { get; set; }

    public int? Usia14TahunTK2 { get; set; }

    public int? Usia518TahunTK2 { get; set; }

    public int? Usia1940TahunTK2 { get; set; }

    public int? Usia4160TahunTK2 { get; set; }

    public int? Usia60TahunTK2 { get; set; }

    public int? DenganKomorbid3 { get; set; }

    public int? TanpaKomorbid3 { get; set; }

    public int? Dirujuk { get; set; }

    public int? IsolasiMandiriDiRumah { get; set; }

    public int? AtasPermintaanSendiriAps { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TglLapor { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
