using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
[Table("ICD10$")]
public partial class ICD10_
{
    [StringLength(255)]
    public string? CODE { get; set; }

    [StringLength(255)]
    public string? DESCRIPTION { get; set; }
}
