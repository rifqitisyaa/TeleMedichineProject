using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RecuringID", "YearPeriod", "MonthPeriod")]
public partial class RecuringDt
{
    [Key]
    public int RecuringID { get; set; }

    [Key]
    public int YearPeriod { get; set; }

    [Key]
    public int MonthPeriod { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateTimeProcess { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ProcessBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProcessDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JournalNo { get; set; }

    public bool IsTerminated { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TerminatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TerminatedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("JournalNo")]
    [InverseProperty("RecuringDt")]
    public virtual JournalHd? JournalNoNavigation { get; set; }

    [ForeignKey("RecuringID")]
    [InverseProperty("RecuringDt")]
    public virtual RecuringHd Recuring { get; set; } = null!;
}
