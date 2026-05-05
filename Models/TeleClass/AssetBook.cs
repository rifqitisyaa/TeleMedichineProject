using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BookCode", "SequenceNo")]
public partial class AssetBook
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string BookCode { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? CalendarCode { get; set; }

    public bool IsPost { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("AssetBook")]
    public virtual ICollection<AssetClassDt> AssetClassDt { get; set; } = new List<AssetClassDt>();

    [InverseProperty("AssetBook")]
    public virtual ICollection<AssetDepreciationParameter> AssetDepreciationParameter { get; set; } = new List<AssetDepreciationParameter>();

    [InverseProperty("AssetBook")]
    public virtual ICollection<Assets> Assets { get; set; } = new List<Assets>();

    [ForeignKey("CalendarCode")]
    [InverseProperty("AssetBook")]
    public virtual AssetCalendarHd? CalendarCodeNavigation { get; set; }
}
