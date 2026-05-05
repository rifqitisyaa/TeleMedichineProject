using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MCUOdontogram
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCTooth { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? SequenceNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? di16 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? di11 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? di26 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? di46 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? di31 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? di36 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? KriteriaDITotal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KriteriaDIKategori { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ci16 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ci11 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ci26 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ci46 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ci31 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ci36 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? KriteriaCITotal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KriteriaCIKategori { get; set; }

    [Unicode(false)]
    public string? d { get; set; }

    [Unicode(false)]
    public string? m { get; set; }

    [Unicode(false)]
    public string? f { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SkorOHISTotal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SkorOHISKategori { get; set; }

    [Unicode(false)]
    public string? dmft { get; set; }

    [Unicode(false)]
    public string? status11 { get; set; }

    [Unicode(false)]
    public string? status12 { get; set; }

    [Unicode(false)]
    public string? status13 { get; set; }

    [Unicode(false)]
    public string? status14 { get; set; }

    [Unicode(false)]
    public string? status15 { get; set; }

    [Unicode(false)]
    public string? status16 { get; set; }

    [Unicode(false)]
    public string? status17 { get; set; }

    [Unicode(false)]
    public string? status18 { get; set; }

    [Unicode(false)]
    public string? status21 { get; set; }

    [Unicode(false)]
    public string? status22 { get; set; }

    [Unicode(false)]
    public string? status23 { get; set; }

    [Unicode(false)]
    public string? status24 { get; set; }

    [Unicode(false)]
    public string? status25 { get; set; }

    [Unicode(false)]
    public string? status26 { get; set; }

    [Unicode(false)]
    public string? status27 { get; set; }

    [Unicode(false)]
    public string? status28 { get; set; }

    [Unicode(false)]
    public string? status31 { get; set; }

    [Unicode(false)]
    public string? status32 { get; set; }

    [Unicode(false)]
    public string? status33 { get; set; }

    [Unicode(false)]
    public string? status34 { get; set; }

    [Unicode(false)]
    public string? status35 { get; set; }

    [Unicode(false)]
    public string? status36 { get; set; }

    [Unicode(false)]
    public string? status37 { get; set; }

    [Unicode(false)]
    public string? status38 { get; set; }

    [Unicode(false)]
    public string? status41 { get; set; }

    [Unicode(false)]
    public string? status42 { get; set; }

    [Unicode(false)]
    public string? status43 { get; set; }

    [Unicode(false)]
    public string? status44 { get; set; }

    [Unicode(false)]
    public string? status45 { get; set; }

    [Unicode(false)]
    public string? status46 { get; set; }

    [Unicode(false)]
    public string? status47 { get; set; }

    [Unicode(false)]
    public string? status48 { get; set; }

    [Unicode(false)]
    public string? kesimpulan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TreatmentDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCToothProblem { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCToothStatus { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ProcedureCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool? IsFirstVisit { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? GCPermukaanGigi { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? GCKeadaanGigi { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? GCBahanRestorasi { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? GCRestorasi { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? GCProtesa { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ditotal { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? citotal { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? dtotal { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? mtotal { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ftotal { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? dmfttotal { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTD { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTDPerawat { get; set; }

    [Unicode(false)]
    public string? NamaDokter { get; set; }

    [Unicode(false)]
    public string? NamaPerawat { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Paramedic { get; set; }

    [Unicode(false)]
    public string? Saran { get; set; }

    [Unicode(false)]
    public string? DokterPelaksana { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CrownBridge { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Protesa { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Impaksi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Ekstrusi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Radix { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Supernumerary { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CbTotal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PTotal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ITotal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ETotal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RTotal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? STotal { get; set; }
}
