using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AnnualMCUCorporateDt
{
    [Key]
    public int ItemID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Kategori { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Position { get; set; }

    public bool IsActive { get; set; }

    [Unicode(false)]
    public string? Summary { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }
}
