using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class KegiatanAlatKelengkapanDewan
{
    [Key]
    public int ID { get; set; }

    public DateOnly Tanggal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JenisRapat { get; set; }

    [Unicode(false)]
    public string? Deskripsi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Bagian { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Kalori { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Kolesterol { get; set; }

    [Unicode(false)]
    public string? DeskripsiKolesterol { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaDokter { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NIP { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaAhliGizi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NIPAhliGizi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SignatureTypePhysician { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SignatureTypeParamedic { get; set; }

    [Column(TypeName = "image")]
    public byte[]? SignaturePhysician { get; set; }

    [Column(TypeName = "image")]
    public byte[]? SignatureParamedic { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SignatureNamePhysician { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SignatureNameParamedic { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SignatureNIPPhysician { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SignatureNIPParamedic { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
