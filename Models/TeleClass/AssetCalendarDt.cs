using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("CalendarCode", "Year", "Period")]
public partial class AssetCalendarDt
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string CalendarCode { get; set; } = null!;

    [Key]
    public int Year { get; set; }

    [Key]
    public int Period { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Label { get; set; } = null!;

    public DateOnly StartingDate { get; set; }

    public DateOnly EndingDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("CalendarCode")]
    [InverseProperty("AssetCalendarDt")]
    public virtual AssetCalendarHd CalendarCodeNavigation { get; set; } = null!;
}
