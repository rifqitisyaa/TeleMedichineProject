using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_PhysicianItem
{
    public int ParamedicID { get; set; }

    public int ItemID { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string ParamedicName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemName1 { get; set; } = null!;

    public bool IsUsingPercentage { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal? FeePercentage { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal FeeAmount { get; set; }
}
