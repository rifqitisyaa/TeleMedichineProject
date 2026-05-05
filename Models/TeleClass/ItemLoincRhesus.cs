using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ItemLoincRhesus
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string BloodRhesus { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? LoincCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? LoincName { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
