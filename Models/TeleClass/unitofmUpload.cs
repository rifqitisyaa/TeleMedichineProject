using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class unitofmUpload
{
    [StringLength(255)]
    public string? UnitOfMeasureCode { get; set; }

    [StringLength(255)]
    public string? UnitOfMeasureName { get; set; }

    [StringLength(255)]
    public string? AlternateUnitOfMeasureName { get; set; }

    [StringLength(255)]
    public string? UnitOfMeasureNameCustom { get; set; }

    [StringLength(255)]
    public string? Remark { get; set; }

    public double? IsActive { get; set; }

    public double? IsDeleted { get; set; }

    [StringLength(255)]
    public string? LastUpdatedBy { get; set; }

    [StringLength(255)]
    public string? LastUpdatedDateTime { get; set; }
}
