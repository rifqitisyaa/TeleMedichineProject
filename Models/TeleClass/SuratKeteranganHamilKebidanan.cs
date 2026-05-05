using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SuratKeteranganHamilKebidanan
{
    [Key]
    [StringLength(300)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? NamaDokter { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NamaPasien { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalLahirPasien { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? UmurPasien { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PekerjaanPasien { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? AlamatPasien { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? DiagnosaPasien { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? KeteranganPasien { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalTTD { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTDDokterTTD { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? DokterBidanTTD { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }
}
