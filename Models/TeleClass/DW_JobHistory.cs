using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("PackageName", "ExecuteDateTime")]
public partial class DW_JobHistory
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string PackageName { get; set; } = null!;

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime ExecuteDateTime { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;
}
