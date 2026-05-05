using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ChecklistPersiapanPasienRujukan
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? NamaPasien { get; set; }

    public DateOnly? TanggalLahirPasien { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? AlamatPasien { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Transportasi { get; set; }

    public bool? TransportasiCheck { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PetugasDokter { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PetugasPerawat { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PetugasAmbulan { get; set; }

    public bool? PetugasCheck { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? KeluargaPendamping { get; set; }

    public bool? KeluargaPendampingCheck { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Surat { get; set; }

    public bool? SuratCheck { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Form { get; set; }

    public bool? FormCheck { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ViaRS { get; set; }

    public bool? ViaRSCheck { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Jaminan { get; set; }

    public bool? JaminanCheck { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Obat1 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Obat2 { get; set; }

    public bool? ObatCheck { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Catatan { get; set; }

    public DateOnly? TTDTanggal { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? TTDNamaDokter { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTDDokter { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    public bool? PetugasDokterCheck { get; set; }

    public bool? PetugasPerawatCheck { get; set; }

    public bool? PetugasAmbulanCheck { get; set; }
}
