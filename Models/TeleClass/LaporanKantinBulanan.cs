using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class LaporanKantinBulanan
{
    [Key]
    public int ID { get; set; }

    public DateOnly? Tanggal { get; set; }

    public bool IsDeleted { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [Unicode(false)]
    public string? Deskripsi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AhliGizi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KepalaYankes { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NIPAhliGizi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NIPKepalaBagianYankes { get; set; }
}
