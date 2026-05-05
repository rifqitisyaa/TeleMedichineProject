using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tempListIndex
{
    [StringLength(128)]
    public string TableName { get; set; } = null!;

    [StringLength(128)]
    public string? IndexName { get; set; }
}
