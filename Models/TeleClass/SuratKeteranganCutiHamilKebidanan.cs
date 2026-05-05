using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class SuratKeteranganCutiHamilKebidanan
{
    [StringLength(200)]
    [Unicode(false)]
    public string? NamaDokter { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NamaPasien { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? UmurPasien { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? AlamatPasien { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PekerjaanPasien { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? MingguHamilPasien { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? BulanHamilPasien { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalTTD { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTDDokterTTD { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? DokterBidanTTD { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [Unicode(false)]
    public string? Diagnosa { get; set; }

    [Unicode(false)]
    public string? Keterangan { get; set; }
}
