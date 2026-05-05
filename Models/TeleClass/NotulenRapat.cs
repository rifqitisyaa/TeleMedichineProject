using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NotulenRapat
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string DocumentNumber { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? TanggalRapat { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JenisRapat { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AgendaRapat { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
