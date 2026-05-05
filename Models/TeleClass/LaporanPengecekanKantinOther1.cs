using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ID", "Nomor")]
public partial class LaporanPengecekanKantinOther1
{
    [Key]
    public int ID { get; set; }

    [Key]
    public int Nomor { get; set; }

    [Unicode(false)]
    public string? NamaKomponen { get; set; }

    public bool IsDeleted { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
