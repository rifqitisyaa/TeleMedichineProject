using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SuratRujukanRadiologiGigi
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Unicode(false)]
    public string? NamaPenderita { get; set; }

    [Unicode(false)]
    public string? AlamatPenderita { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TeleponPenderita { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Umur { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JKPenderita { get; set; }

    [Unicode(false)]
    public string? NamaDokter { get; set; }

    [Unicode(false)]
    public string? AlamatDokter { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TeleponDokter { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Tanggal { get; set; }

    public bool? Check8AtasKanan { get; set; }

    public bool? Check7AtasKanan { get; set; }

    public bool? Check6AtasKanan { get; set; }

    public bool? Check5AtasKanan { get; set; }

    public bool? Check4AtasKanan { get; set; }

    public bool? Check3AtasKanan { get; set; }

    public bool? Check2AtasKanan { get; set; }

    public bool? Check1AtasKanan { get; set; }

    public bool? Check1AtasKiri { get; set; }

    public bool? Check2AtasKiri { get; set; }

    public bool? Check3AtasKiri { get; set; }

    public bool? Check4AtasKiri { get; set; }

    public bool? Check5AtasKiri { get; set; }

    public bool? Check6AtasKiri { get; set; }

    public bool? Check7AtasKiri { get; set; }

    public bool? Check8AtasKiri { get; set; }

    public bool? Check8BawahKanan { get; set; }

    public bool? Check7BawahKanan { get; set; }

    public bool? Check6BawahKanan { get; set; }

    public bool? Check5BawahKanan { get; set; }

    public bool? Check4BawahKanan { get; set; }

    public bool? Check3BawahKanan { get; set; }

    public bool? Check2BawahKanan { get; set; }

    public bool? Check1BawahKanan { get; set; }

    public bool? Check1BawahKiri { get; set; }

    public bool? Check2BawahKiri { get; set; }

    public bool? Check3BawahKiri { get; set; }

    public bool? Check4BawahKiri { get; set; }

    public bool? Check5BawahKiri { get; set; }

    public bool? Check6BawahKiri { get; set; }

    public bool? Check7BawahKiri { get; set; }

    public bool? Check8BawahKiri { get; set; }

    public bool? CheckIAtasKiri { get; set; }

    public bool? CheckIIAtasKiri { get; set; }

    public bool? CheckIIIAtasKiri { get; set; }

    public bool? CheckIVAtasKiri { get; set; }

    public bool? CheckVAtasKiri { get; set; }

    public bool? CheckIAtasKanan { get; set; }

    public bool? CheckIIAtasKanan { get; set; }

    public bool? CheckIIIAtasKanan { get; set; }

    public bool? CheckIVAtasKanan { get; set; }

    public bool? CheckVAtasKanan { get; set; }

    public bool? CheckIBawahKanan { get; set; }

    public bool? CheckIIBawahKanan { get; set; }

    public bool? CheckIIIBawahKanan { get; set; }

    public bool? CheckIVBawahKanan { get; set; }

    public bool? CheckVBawahKanan { get; set; }

    public bool? CheckIBawahKiri { get; set; }

    public bool? CheckIIBawahKiri { get; set; }

    public bool? CheckIIIBawahKiri { get; set; }

    public bool? CheckIVBawahKiri { get; set; }

    public bool? CheckVBawahKiri { get; set; }

    public bool? KeteranganXRay { get; set; }

    [Unicode(false)]
    public string? Diagnosa { get; set; }

    public bool? KeteranganHasil { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTD { get; set; }

    [Unicode(false)]
    public string? TTDNamaDokter { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    public bool? HasilDokter { get; set; }

    public bool? HasilPasien { get; set; }

    public bool? Dental { get; set; }

    public bool? Paranomic { get; set; }

    public bool? Cephalometri { get; set; }

    public bool? Oclusal { get; set; }

    public bool? TMJ { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaXray { get; set; }
}
