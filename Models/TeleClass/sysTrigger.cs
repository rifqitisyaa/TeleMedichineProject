using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class sysTrigger
{
    [Key]
    [StringLength(200)]
    [Unicode(false)]
    public string TriggerName { get; set; } = null!;

    [StringLength(1000)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [Unicode(false)]
    public string TriggerContent { get; set; } = null!;

    public bool? IsForInsert { get; set; }

    public bool? IsForUpdate { get; set; }

    public bool? IsForDelete { get; set; }

    public int TableID { get; set; }

    public bool? IsDeleted { get; set; }

    public bool IsActive { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
