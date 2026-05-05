using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class LaporanBulananPasienPoliGizi
{
    [Key]
    public int ID { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public bool IsDeleted { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AhliGizi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KepalaBagianYankes { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NIPAhliGizi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NIPKepalaBagianYankes { get; set; }
}
