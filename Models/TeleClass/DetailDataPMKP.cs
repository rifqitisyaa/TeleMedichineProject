using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SequenceReportID", "PeriodID")]
public partial class DetailDataPMKP
{
    [Key]
    public int SequenceReportID { get; set; }

    [Key]
    public int PeriodID { get; set; }

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

    [StringLength(255)]
    [Unicode(false)]
    public string Deminator { get; set; } = null!;

    public int TargetData { get; set; }

    public double Pencapaian { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? RealisasiBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RealisasiDate { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? TargetBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TargetDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
