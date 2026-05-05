using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class VitalSignMachineMapping
{
    [StringLength(50)]
    [Unicode(false)]
    public string? VitalSignCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VitalSignCodeMachine { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDelete { get; set; }
}
