using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class _SearchWordDiagnose
{
    [Key]
    public long Id { get; set; }

    [Unicode(false)]
    public string? SearchWord { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? UserName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SearchDateTime { get; set; }
}
