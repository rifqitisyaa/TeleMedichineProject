using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class Rl31MasterData
{
    [StringLength(50)]
    [Unicode(false)]
    public string? ColNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ColType { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CodeParameter { get; set; }
}
