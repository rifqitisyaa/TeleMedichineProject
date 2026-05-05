using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ResponseRujukanSisrute
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string NoRujukanSisrute { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Jawaban { get; set; }

    [Unicode(false)]
    public string? Alasan { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTIme { get; set; }
}
