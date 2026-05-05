using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class WordRelated
{
    [Key]
    public int ID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Word { get; set; } = null!;

    public int? NextID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? sdex { get; set; }
}
