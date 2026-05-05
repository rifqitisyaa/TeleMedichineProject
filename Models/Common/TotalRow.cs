using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[Keyless]
public partial class TotalRow
{
    [Column("TotalRow", TypeName = "numeric(18, 2)")]
    public decimal? TotalRow1 { get; set; }
}
