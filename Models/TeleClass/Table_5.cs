using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Table_5
{
    [Key]
    [StringLength(25)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public DateOnly? Tanggal { get; set; }

    public DateOnly? HaidTerakhir { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TekDarah { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BeratBadan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Keluhan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PemeriksaanTindakan { get; set; }

    public DateOnly? DipesanKembali { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Keterangan { get; set; }

    public bool? isDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
