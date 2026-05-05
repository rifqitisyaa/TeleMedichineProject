using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class sysMessageTemp
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string MessageID { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string MessageText { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? MessageTextCustom { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? GCMessageType { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
