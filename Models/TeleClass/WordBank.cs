using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class WordBank
{
    [Key]
    [StringLength(200)]
    [Unicode(false)]
    public string Word { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? CorrectedCode { get; set; }
}
