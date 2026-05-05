using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Sct
{
    [Key]
    [StringLength(255)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? Display { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Keterangan { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ReferrenceCode { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
