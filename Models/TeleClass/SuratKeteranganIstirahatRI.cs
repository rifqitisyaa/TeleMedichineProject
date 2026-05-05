using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SuratKeteranganIstirahatRI
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Nama { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JenisKelamin { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TglLahir { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RekamMedis { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Pekerjaan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TglOpname { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TglPulang { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TglAwal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TglAkhir { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
