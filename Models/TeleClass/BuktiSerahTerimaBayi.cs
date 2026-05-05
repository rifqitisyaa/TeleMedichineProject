using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class BuktiSerahTerimaBayi
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? NamaKeluarga { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? JkKeluarga { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? UmurKeluarga { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? AlamatKeluarga { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? HubKeluarga { get; set; }

    public DateOnly? TglMulai { get; set; }

    public DateOnly? TglTtd { get; set; }

    public DateOnly? TglTtd1 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? AtasNamaPK1 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? AtasNamaRS1 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? AtasNamaPK2 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? AtasNamaRS2 { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Ttd1 { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Ttd2 { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Ttd3 { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Ttd4 { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
