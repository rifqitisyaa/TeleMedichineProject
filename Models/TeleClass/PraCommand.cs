using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PraCommand
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [Unicode(false)]
    public string SqlCommand { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? StartingDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndingDate { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool? IsUsedInPRA { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
