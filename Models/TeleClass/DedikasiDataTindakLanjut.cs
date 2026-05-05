using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class DedikasiDataTindakLanjut
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? TanggalPemeriksaan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NoWhatsApp { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? MasalahKesehatan1 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? MasalahKesehatan2 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? MasalahKesehatan3 { get; set; }

    public bool? RujukDokter { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RujukDokterDate { get; set; }

    public bool? RujukGizi { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RujukGiziDate { get; set; }

    public bool? Seminar { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SeminarDate { get; set; }

    public bool? DokterUmum { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DokterUmumDate { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
