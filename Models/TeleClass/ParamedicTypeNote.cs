using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("GCParamedicType", "GCNote")]
public partial class ParamedicTypeNote
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCParamedicType { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCNote { get; set; } = null!;

    public bool? IsActive { get; set; }
}
