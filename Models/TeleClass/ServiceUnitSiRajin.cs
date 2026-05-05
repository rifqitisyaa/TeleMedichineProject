using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ServiceUnitSiRajin
{
    [Key]
    public int id { get; set; }

    [Column("ServiceUnitSiRajin")]
    public int? ServiceUnitSiRajin1 { get; set; }

    public int? ServiceUnitID { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    public DateOnly? LastUpdatedDateTime { get; set; }
}
