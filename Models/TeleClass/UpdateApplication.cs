using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class UpdateApplication
{
    [Key]
    public int id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string PatchName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PatchDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string IssueType { get; set; } = null!;

    [Unicode(false)]
    public string IssueDescription { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdateDateTime { get; set; }
}
