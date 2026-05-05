using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PermohonanPelayananKontrasepsi
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? NamaIstri { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? NamaSuami { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NoSeriKartu { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Alamat { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalBuat { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Pelayanan { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTDDokter { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? NamaDokter { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTDPemohon { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? NamaPemohon { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTDPasanganPeserta { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? NamaPasanganPeserta { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? NamaRS { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PermohonanPelayananKontrasepsi")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
