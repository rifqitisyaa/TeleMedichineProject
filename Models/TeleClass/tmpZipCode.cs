using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tmpZipCode
{
    [StringLength(255)]
    public string? ZipCodeID { get; set; }

    [StringLength(255)]
    public string? ZipCode { get; set; }

    [StringLength(255)]
    public string? Line1 { get; set; }

    [StringLength(255)]
    public string? Line2 { get; set; }

    [StringLength(255)]
    public string? District { get; set; }

    [StringLength(255)]
    public string? County { get; set; }

    [StringLength(255)]
    public string? City { get; set; }

    [StringLength(255)]
    public string? GCProvince { get; set; }

    [StringLength(255)]
    public string? IsDeleted { get; set; }

    [StringLength(255)]
    public string? LastUpdatedBy { get; set; }

    [StringLength(255)]
    public string? LastUpdatedDateTime { get; set; }
}
