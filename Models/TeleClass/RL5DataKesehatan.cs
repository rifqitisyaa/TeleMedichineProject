using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "Period")]
public partial class RL5DataKesehatan
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    [StringLength(6)]
    [Unicode(false)]
    public string Period { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string DokumenQ1 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string DokumenQ2 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LimbahCairQ1 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LimbahCairQ2 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LimbahCairQ3Kuartal1 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LimbahCairQ3Kuartal2 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LimbahCairQ3Kuartal3 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LimbahCairQ4 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LimbahCairQ5 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LimbahPadatQ1 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LimbahPadatQ2 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LimbahPadatQ3 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LimbahPadatQ4 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LimbahPadatQ5 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LimbahPadatQ6 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LimbahPadatQ7 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string PenyehatanAirQ1 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string PenyehatanAirQ2 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string PenyehatanAirQ3 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string PenyehatanAirQ4Kuartal1 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string PenyehatanAirQ4Kuartal2 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string PenyehatanAirQ4Kuartal3 { get; set; } = null!;

    public bool IsProceed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("RL5DataKesehatan")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
