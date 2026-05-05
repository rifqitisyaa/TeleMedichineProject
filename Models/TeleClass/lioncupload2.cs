using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class lioncupload2
{
    [StringLength(255)]
    public string? LOINC_NUM { get; set; }

    [StringLength(255)]
    public string? COMPONENT { get; set; }

    [StringLength(255)]
    public string? PROPERTY { get; set; }

    [StringLength(255)]
    public string? TIME_ASPCT { get; set; }

    [StringLength(255)]
    public string? SYSTEM { get; set; }

    [StringLength(255)]
    public string? SCALE_TYP { get; set; }

    [StringLength(255)]
    public string? METHOD_TYP { get; set; }

    [StringLength(255)]
    public string? CLASS { get; set; }

    public double? CLASSTYPE { get; set; }

    [StringLength(255)]
    public string? LONG_COMMON_NAME { get; set; }

    [StringLength(255)]
    public string? SHORTNAME { get; set; }

    [StringLength(255)]
    public string? STATUS { get; set; }
}
