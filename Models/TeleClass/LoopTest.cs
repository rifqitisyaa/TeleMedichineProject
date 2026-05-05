using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class LoopTest
{
    public int Id { get; set; }

    public int? LoopNum { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExecutedAt { get; set; }
}
