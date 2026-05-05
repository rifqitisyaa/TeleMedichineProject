using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SysPatientMergeHd
{
    [Key]
    [StringLength(35)]
    [Unicode(false)]
    public string MenuId { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string MenuCaption { get; set; } = null!;

    [Unicode(false)]
    public string? NumberOfRecordCommand { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SPViewDetail { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
