using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class SuratKeteranganPerjalanan
{
    [StringLength(300)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? NamaPasien { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? AlamatPasien { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? DiagnosaPasien { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? TransportasiPasien { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalTTD { get; set; }

    [Column(TypeName = "image")]
    public byte[]? DokterBidanTTD { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NamaDokter { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateTime { get; set; }
}
