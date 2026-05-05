using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ItemLabDisplay
{
    [Key]
    public int ItemID { get; set; }

    public int Position { get; set; }

    public int Lv { get; set; }

    public bool Bold { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ParentID { get; set; }

    public bool IsHeader { get; set; }

    [Unicode(false)]
    public string? MetodePemeriksaan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCControlType { get; set; }

    public bool IsDelete { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime lastUpdateDateTime { get; set; }
}
