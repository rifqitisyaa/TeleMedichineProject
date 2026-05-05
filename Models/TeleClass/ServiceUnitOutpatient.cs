using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("No", "JenisKegiatan")]
public partial class ServiceUnitOutpatient
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string No { get; set; } = null!;

    [Key]
    [StringLength(500)]
    [Unicode(false)]
    public string JenisKegiatan { get; set; } = null!;

    [Unicode(false)]
    public string? ServiceUnitID { get; set; }

    public int? NoUrut { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
