using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SuratKeteranganPasien
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? TanggalOpnameAkhir { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Anamnese { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? PemeriksaanFisik { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? PemeriksaanPenunjang { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? PemeriksaanThorax { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? PemeriksaanLaboratorium { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Diagnosa { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Tindakan { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Terapi { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
