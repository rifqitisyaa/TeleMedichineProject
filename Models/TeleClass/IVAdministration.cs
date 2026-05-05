using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("JobOrderNo", "SequenceNo")]
public partial class IVAdministration
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int? ItemID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StatusPemasangan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AdministrationDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PerawatPasang { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NoIV { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LokasiIV { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PivasScore { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PerawatLepas { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LamaPasang { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaCairan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JenisCairan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ObatYangDiberikan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool? IsCompleted { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
