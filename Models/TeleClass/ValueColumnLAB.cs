using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class ValueColumnLAB
{
    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(203)]
    [Unicode(false)]
    public string NameLab { get; set; } = null!;

    [StringLength(502)]
    [Unicode(false)]
    public string? HasilTest { get; set; }

    public long? Ordering { get; set; }
}
