using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class KetersediaanKebutuhanAlkes
{
    [Key]
    public int IdKebutuhan { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string Kebutuhan { get; set; } = null!;

    public int? JumlahEksisting { get; set; }

    public int? Jumlah { get; set; }

    public int? Jumlah_diterima { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tglUpdate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KeteranganKetersediaan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PemakaianTahunSebelumnya { get; set; }
}
