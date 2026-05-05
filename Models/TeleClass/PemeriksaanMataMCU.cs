using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class PemeriksaanMataMCU
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    public int SequenceNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? FisikMata { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ButaWarna { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VisusOS { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VisusOD { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Okulerkiri { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Okulerkanan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Okuler { get; set; }

    [Unicode(false)]
    public string? Keterangan1 { get; set; }

    [Unicode(false)]
    public string? Keterangan2 { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTD { get; set; }

    [Unicode(false)]
    public string? Kesimpulan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VisusKananKoreksi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VisusKiriKoreksi { get; set; }

    [Unicode(false)]
    public string? ParamedicName { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? AddPlus { get; set; }
}
