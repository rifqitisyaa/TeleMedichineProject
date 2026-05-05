using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class NotaDinasTable
{
    [StringLength(50)]
    [Unicode(false)]
    public string? JenisNota { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TanggalNota { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string NomorNota { get; set; } = null!;

    [Unicode(false)]
    public string? TujuanNota { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AsalNota { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Perihal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LokasiNota { get; set; }

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
