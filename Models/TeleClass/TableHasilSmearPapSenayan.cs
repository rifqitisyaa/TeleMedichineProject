using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class TableHasilSmearPapSenayan
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? G { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? P { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? A { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HaidTerakhir { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SiklusHaid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Mens { get; set; }

    [Unicode(false)]
    public string? Pilihan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Tanggal { get; set; }

    [Unicode(false)]
    public string? DataKlinik { get; set; }

    [Unicode(false)]
    public string? NoSitologi { get; set; }

    [Unicode(false)]
    public string? HasilSitologi { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsReviewed { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedTime { get; set; }
}
