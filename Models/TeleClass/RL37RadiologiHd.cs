using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class RL37RadiologiHd
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? No { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? JenisKegiatan { get; set; }

    public int? OrderNo { get; set; }
}
