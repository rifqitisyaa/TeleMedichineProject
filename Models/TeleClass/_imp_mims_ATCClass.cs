using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class _imp_mims_ATCClass
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ATCClassCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ATCClassName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? ParentCode { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDate { get; set; }
}
