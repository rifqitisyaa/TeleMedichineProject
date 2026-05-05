using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MasterReferensiSdm
{
    [Key]
    public int IdKebutuhan { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string Kebutuhan { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TipeKebutuhan { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
