using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_CycleCounting
{
    [Column("CC No")]
    [StringLength(20)]
    [Unicode(false)]
    public string CC_No { get; set; } = null!;

    [Column("CC Date")]
    public DateOnly CC_Date { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Department { get; set; } = null!;

    [Column("Service Unit")]
    [StringLength(100)]
    [Unicode(false)]
    public string Service_Unit { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Location { get; set; } = null!;

    [Column("ABC Class")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ABC_Class { get; set; }

    [Column("Item Name")]
    [StringLength(100)]
    [Unicode(false)]
    public string Item_Name { get; set; } = null!;

    [Column("Item Type")]
    [StringLength(100)]
    [Unicode(false)]
    public string Item_Type { get; set; } = null!;

    [Column("Item Group")]
    [StringLength(100)]
    [Unicode(false)]
    public string Item_Group { get; set; } = null!;

    [Column("System Qty", TypeName = "numeric(10, 2)")]
    public decimal System_Qty { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Differences { get; set; }

    [Column("Range Qty")]
    [StringLength(43)]
    [Unicode(false)]
    public string? Range_Qty { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal? Accuracy { get; set; }

    [Column("Difference Amount", TypeName = "numeric(18, 2)")]
    public decimal? Difference_Amount { get; set; }

    public int Hit { get; set; }

    public bool? IsApproved { get; set; }

    public bool IsDeleted { get; set; }
}
