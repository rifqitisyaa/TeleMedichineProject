using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class _bak_sysParameter
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ParameterCode { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string ParameterName { get; set; } = null!;

    [Unicode(false)]
    public string ParameterValue { get; set; } = null!;

    public bool? IsBySite { get; set; }

    public bool? IsUsedBySystem { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
