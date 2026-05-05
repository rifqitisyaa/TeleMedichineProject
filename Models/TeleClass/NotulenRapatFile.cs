using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NotulenRapatFile
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string DocumentId { get; set; } = null!;

    public int? DocumentNumber { get; set; }

    public int? ItemID { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? DetailNo { get; set; }

    [StringLength(300)]
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
