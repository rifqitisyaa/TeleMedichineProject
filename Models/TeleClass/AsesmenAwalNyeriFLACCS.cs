using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class AsesmenAwalNyeriFLACCS
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
    public DateTime? AssessmentDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Wajah { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Kaki { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Aktifitas { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Menangis { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Kenyamanan { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Tindakan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaPerawat { get; set; }

    public int? NyeriScore { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NyeriCategory { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
