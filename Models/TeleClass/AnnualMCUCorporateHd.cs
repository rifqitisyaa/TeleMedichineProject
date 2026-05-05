using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AnnualMCUCorporateHd
{
    [Key]
    public int ItemID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Kategori { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
