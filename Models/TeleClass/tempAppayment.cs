using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tempAppayment
{
    [StringLength(20)]
    [Unicode(false)]
    public string APNo { get; set; } = null!;

    [Column(TypeName = "numeric(38, 4)")]
    public decimal? Payment { get; set; }
}
