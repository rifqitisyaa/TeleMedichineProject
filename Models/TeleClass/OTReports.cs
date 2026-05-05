using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class OTReports
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? OTReportDateTime { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Kategory { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TipeOperasi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KriteriatOperasi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? JenisAnestesi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Tindakan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PenggunaanAlatMedisDanPemeriksaan { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
