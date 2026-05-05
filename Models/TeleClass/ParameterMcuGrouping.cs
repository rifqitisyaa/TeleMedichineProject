using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class ParameterMcuGrouping
{
    [Unicode(false)]
    public string? ParameterGrouping { get; set; }

    public int? countData { get; set; }
}
