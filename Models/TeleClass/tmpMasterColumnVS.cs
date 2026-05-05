using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tmpMasterColumnVS
{
    [StringLength(105)]
    [Unicode(false)]
    public string VitalSignCode { get; set; } = null!;

    public long? Ordering { get; set; }
}
