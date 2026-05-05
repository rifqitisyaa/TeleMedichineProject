using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TestHl7Message
{
    [Key]
    public long Id { get; set; }

    [Unicode(false)]
    public string? MessageText { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MessageDateTime { get; set; }
}
