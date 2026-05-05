using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("JobOrderNo", "SequenceNo", "ItemID")]
public partial class CriticalResultReport
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    public int ItemID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ResultDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReportDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Durasi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Pelapor { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Penerima { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MenisKonfirPerawat { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? AdvisDokter { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
