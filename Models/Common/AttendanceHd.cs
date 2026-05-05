using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class AttendanceHd
{
    [Key]
    public int PeriodID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartPeriod { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndPeriod { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
