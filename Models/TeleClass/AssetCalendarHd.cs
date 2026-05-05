using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AssetCalendarHd
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("CalendarCodeNavigation")]
    public virtual ICollection<AssetBook> AssetBook { get; set; } = new List<AssetBook>();

    [InverseProperty("CalendarCodeNavigation")]
    public virtual ICollection<AssetCalendarDt> AssetCalendarDt { get; set; } = new List<AssetCalendarDt>();
}
