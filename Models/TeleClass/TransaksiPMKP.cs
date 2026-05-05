using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("PeriodID", "SequenceReportID")]
public partial class TransaksiPMKP
{
    [Key]
    public int PeriodID { get; set; }

    [Key]
    public int SequenceReportID { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string PeriodeName { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string GroupType { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string IndikatorName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? GroupID { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string NominatorName { get; set; } = null!;

    public int Nominator { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string DeminatorName { get; set; } = null!;

    public int Deminator { get; set; }

    public int TargetData { get; set; }

    public double pencapaian { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }
}
