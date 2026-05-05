using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DocumentationTable
{
    [StringLength(50)]
    [Unicode(false)]
    public string? JenisSurat { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TanggalSurat { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string NomorSurat { get; set; } = null!;

    [Unicode(false)]
    public string? TujuanSurat { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AsalSurat { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Perihal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LokasiSurat { get; set; }

    public int? ServiceUnitID { get; set; }

    public bool? IsRead { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TanggalUpdate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [Unicode(false)]
    public string? Catatan { get; set; }
}
