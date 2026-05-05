using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PatientEktpReader
{
    [Key]
    [StringLength(25)]
    [Unicode(false)]
    public string NIK { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? Nama { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TempatLahir { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TanggalLahir { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? GolonganDarah { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Alamat { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RW { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Kecamatan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Kelurahan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Agama { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MaritalStatus { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Pekerjaan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Provinsi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Kabupaten { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Kewarganegaraan { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? BerlakuHingga { get; set; }

    public bool? IsProceed { get; set; }
}
