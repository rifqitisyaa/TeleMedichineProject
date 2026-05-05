using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("AssetsCode", "SequenceNo")]
public partial class AssetInspectionDt
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string AssetsCode { get; set; } = null!;

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? InspectionDate { get; set; }

    [Unicode(false)]
    public string? InspectionDescription { get; set; }

    public bool Yes { get; set; }

    public bool No { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
