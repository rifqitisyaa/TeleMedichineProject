using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ID", "DetailNo")]
public partial class MonitoringKantinOther2
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

    [StringLength(20)]
    [Unicode(false)]
    public string? GCMonitoring { get; set; }

    public bool IsDeleted { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
