using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DocumentationTableFile
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string NomorSurat { get; set; } = null!;

    [Unicode(false)]
    public string? NomorGambar { get; set; }

    public int? ItemID { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? DetailNo { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? FileName { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedDateTime { get; set; }
}
