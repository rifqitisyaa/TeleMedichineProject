using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[PrimaryKey("PeriodID", "SequenceNo")]
public partial class AttendanceDt
{
    [Key]
    public int PeriodID { get; set; }

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ParamedicID { get; set; }

    public int TotalAttendance { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
