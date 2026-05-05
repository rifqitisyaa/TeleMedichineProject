using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class Atc
{
    [StringLength(255)]
    public string? Code { get; set; }

    [StringLength(255)]
    public string? Display { get; set; }

    [StringLength(255)]
    public string? Keterangan { get; set; }

    [StringLength(255)]
    public string? ReferrenceCode { get; set; }

    [StringLength(255)]
    public string? Remark { get; set; }

    public double? IsActive { get; set; }

    public double? IsDeleted { get; set; }

    [StringLength(255)]
    public string? LastUpdatedBy { get; set; }

    [StringLength(255)]
    public string? LastUpdatedDateTime { get; set; }
}
