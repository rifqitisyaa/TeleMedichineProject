using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AssetDepreciationMethod
{
    [Key]
    public int MethodID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string MethodDescription { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDepreciationMethod { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCConventionMethod { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Method")]
    public virtual ICollection<AssetClassDt> AssetClassDt { get; set; } = new List<AssetClassDt>();

    [InverseProperty("Method")]
    public virtual ICollection<AssetDepreciationParameter> AssetDepreciationParameter { get; set; } = new List<AssetDepreciationParameter>();

    [ForeignKey("GCConventionMethod")]
    [InverseProperty("AssetDepreciationMethodGCConventionMethodNavigation")]
    public virtual sysGeneralCode? GCConventionMethodNavigation { get; set; }

    [ForeignKey("GCDepreciationMethod")]
    [InverseProperty("AssetDepreciationMethodGCDepreciationMethodNavigation")]
    public virtual sysGeneralCode? GCDepreciationMethodNavigation { get; set; }
}
