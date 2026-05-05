using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class NursingActivityGroup
{
    [StringLength(255)]
    public string? ActivityCode { get; set; }

    [StringLength(255)]
    public string? GroupName { get; set; }
}
