using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NotaDinasKeluarFile
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string idFile { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? NomorNota { get; set; }

    [Unicode(false)]
    public string? FileName { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
