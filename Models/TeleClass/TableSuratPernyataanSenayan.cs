using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TableSuratPernyataanSenayan
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Nama { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Umur { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TglLahir { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Alamat { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Telp { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Perwakilan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nama1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Gender1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Umur1 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TglLahir1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Diagnosa { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Rtm { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Rtm2 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Persetujuan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Ttd { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TtdNama { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TtdImage { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TtdImagePasien { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TtdNamaPasien { get; set; }
}
