using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class RekeningAir
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string NomorIDPelanggan { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string NamaPelanggan { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Lokasi { get; set; }

    [Unicode(false)]
    public string? Alamat { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDatetime { get; set; }
}
