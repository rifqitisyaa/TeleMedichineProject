using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[Keyless]
public partial class HelpLink
{
    [StringLength(255)]
    public string? MenuID { get; set; }

    [StringLength(255)]
    public string? LinkID { get; set; }
}
