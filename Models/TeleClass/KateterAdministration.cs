using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class KateterAdministration
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? TanggalPemasangan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalLepas { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NoKateter { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JenisKateter { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LamaPemakaian { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemPencegahanISK { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GejalaISK { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
