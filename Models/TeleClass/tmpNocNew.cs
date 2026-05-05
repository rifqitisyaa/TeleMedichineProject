using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tmpNocNew
{
    [StringLength(255)]
    public string? NandaCode { get; set; }

    [StringLength(255)]
    public string? NocCode { get; set; }

    [StringLength(255)]
    public string? LastUpdateBy { get; set; }

    [StringLength(255)]
    public string? LastUpdateDateTime { get; set; }
}
