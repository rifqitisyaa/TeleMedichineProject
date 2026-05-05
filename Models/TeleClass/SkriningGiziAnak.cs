using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class SkriningGiziAnak
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AssessmentDateTime { get; set; }

    public int? ParamedicID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Pertanyaan1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Pertanyaan2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Pertanyaan3 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Pertanyaan4 { get; set; }

    public int? SkorSGASK { get; set; }

    [Unicode(false)]
    public string? Pengetahuan { get; set; }

    [Unicode(false)]
    public string? Tanggapan { get; set; }

    [Unicode(false)]
    public string? Terapi { get; set; }

    [Unicode(false)]
    public string? Pemeriksaan { get; set; }

    [Unicode(false)]
    public string? Catatan { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
