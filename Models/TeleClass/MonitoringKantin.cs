using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MonitoringKantin
{
    [Key]
    public int ID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Lokasi { get; set; }

    public DateOnly? Tanggal { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [Unicode(false)]
    public string? Saran { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AhliGizi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PenanggungJawab { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CounterKantin { get; set; }

    [InverseProperty("IDNavigation")]
    public virtual ICollection<MonitoringKantinOther> MonitoringKantinOther { get; set; } = new List<MonitoringKantinOther>();
}
