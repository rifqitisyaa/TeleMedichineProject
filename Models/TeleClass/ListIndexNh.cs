using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class ListIndexNh
{
    [StringLength(200)]
    [Unicode(false)]
    public string? TableName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? IndexName { get; set; }
}
