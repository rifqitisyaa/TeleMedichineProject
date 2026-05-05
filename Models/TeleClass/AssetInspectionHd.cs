using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AssetInspectionHd
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string AssetsCode { get; set; } = null!;

    public int ServiceUnitID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    public int AssetID { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
