using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class GroupLabImport
{
    [StringLength(255)]
    public string? ItemgroupName1 { get; set; }

    [StringLength(255)]
    public string? ItemGroupCode { get; set; }
}
