using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("CalenderID", "CalenderDate", "SequenceNo")]
[Index("WorkStationCode", "CalenderDate", "IsHoliday", Name = "IX_CalenderDt")]
public partial class CalenderDt
{
    [Key]
    public int CalenderID { get; set; }

    [Key]
    public DateOnly CalenderDate { get; set; }

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string StartingTime { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string EndingTime { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string WorkStationCode { get; set; } = null!;

    public bool? IsHoliday { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("CalenderID")]
    [InverseProperty("CalenderDt")]
    public virtual CalenderHd Calender { get; set; } = null!;

    [ForeignKey("WorkStationCode")]
    [InverseProperty("CalenderDt")]
    public virtual WorkStation WorkStationCodeNavigation { get; set; } = null!;
}
