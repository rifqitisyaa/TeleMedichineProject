using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class CalenderHd
{
    [Key]
    public int CalenderID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CalenderName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string WorkStationCode { get; set; } = null!;

    public DateOnly StartingDate { get; set; }

    public DateOnly EndingDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Calender")]
    public virtual ICollection<CalenderDt> CalenderDt { get; set; } = new List<CalenderDt>();

    [ForeignKey("SiteCode")]
    [InverseProperty("CalenderHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
