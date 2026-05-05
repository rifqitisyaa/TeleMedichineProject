using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class VitalSignMachineMessageHd
{
    [StringLength(20)]
    [Unicode(false)]
    public string? MessageID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MessageDateTime { get; set; }

    [Unicode(false)]
    public string? MessageText { get; set; }
}
