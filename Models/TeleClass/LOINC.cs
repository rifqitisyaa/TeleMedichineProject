using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class LOINC
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string LOINCCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string ComponentName { get; set; } = null!;

    [Unicode(false)]
    public string? ComponentLongName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ComponentShortName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Property { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TimeAspect { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? System { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ScaleType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MethodType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Class { get; set; }

    public int? ClassType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferenceCode { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
