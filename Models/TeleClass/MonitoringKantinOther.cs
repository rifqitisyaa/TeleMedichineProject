using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ID", "DetailNo")]
public partial class MonitoringKantinOther
{
    [Key]
    public int ID { get; set; }

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string DetailNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? StandarRuangan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Kondisi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Keterangan { get; set; }

    public bool? Penilaian1 { get; set; }

    public bool? Penilaian2 { get; set; }

    public bool? Penilaian3 { get; set; }

    public bool? Penilaian4 { get; set; }

    public bool? Penilaian5 { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCMonitoring { get; set; }

    public int? Nomor { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CounterKantin { get; set; }

    [ForeignKey("ID")]
    [InverseProperty("MonitoringKantinOther")]
    public virtual MonitoringKantin IDNavigation { get; set; } = null!;
}
