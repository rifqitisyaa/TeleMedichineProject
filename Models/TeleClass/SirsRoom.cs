using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SirsRoom
{
    [Key]
    public long ID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ID_TT { get; set; } = null!;

    [Unicode(false)]
    public string TT { get; set; } = null!;

    [Unicode(false)]
    public string? RoomName { get; set; }

    public int? Jumlah_Ruang { get; set; }

    public int? Jumlah { get; set; }

    public int? Terpakai { get; set; }

    public bool IsCovid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
