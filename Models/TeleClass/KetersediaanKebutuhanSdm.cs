using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class KetersediaanKebutuhanSdm
{
    public int IdKebutuhan { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string Kebutuhan { get; set; } = null!;

    public int? JumlahEksisting { get; set; }

    public int? jumlah { get; set; }

    public int? jumlah_diterima { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tglupdate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
