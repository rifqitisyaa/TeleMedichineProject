using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class sysParamedicNameFormat
{
    [Key]
    public short NameID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string NameType { get; set; } = null!;

    public bool IsVisible { get; set; }

    public short IndexNo { get; set; }

    public bool IsUppercase { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string StartDelimiter { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string EndDelimiter { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
