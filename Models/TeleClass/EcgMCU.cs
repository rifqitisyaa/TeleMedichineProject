using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class EcgMCU
{
    [StringLength(15)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCTooth { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? SequenceNo { get; set; }

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Irama { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PWave { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PRInterval { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? QRSInterval { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? VentricularRate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? QRISAxis { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? STSegment { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TWave { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LainLain { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Kesimpulan { get; set; }

    [Unicode(false)]
    public string? Saran { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [Unicode(false)]
    public string? DokterPelaksana { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTD { get; set; }

    public bool? PerluTreadmill { get; set; }

    [Unicode(false)]
    public string? NamaPerawat { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTDPerawat { get; set; }
}
