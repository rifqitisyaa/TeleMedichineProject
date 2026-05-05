using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class sysUserThemes
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string UserID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string BackgroundPath { get; set; } = null!;

    [Column(TypeName = "numeric(3, 1)")]
    public decimal Opacity { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ThemesColour { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
