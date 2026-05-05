using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class ListAdvanceMasterCheck
{
    [StringLength(10)]
    [Unicode(false)]
    public string? No { get; set; }

    [Unicode(false)]
    public string? MasterChecking { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? DataMasterCount { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? DataMasterValid { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? DataMasterInvalid { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? DataMasterValidPercentage { get; set; }

    [Unicode(false)]
    public string? DataResultRemarks { get; set; }
}
