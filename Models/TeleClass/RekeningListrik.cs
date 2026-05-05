using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class RekeningListrik
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string NomorIDPelanggan { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaPelanggan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Lokasi { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? AlamatPelanggan { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
