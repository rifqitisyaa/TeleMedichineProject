using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tempARpribadirudy
{
    [StringLength(60)]
    [Unicode(false)]
    public string registrationNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ReferenceNo { get; set; } = null!;

    [Column(TypeName = "numeric(38, 4)")]
    public decimal? Amount { get; set; }
}
