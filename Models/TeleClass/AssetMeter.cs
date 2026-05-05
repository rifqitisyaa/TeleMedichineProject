using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AssetMeter
{
    [Key]
    public int Id { get; set; }

    public int AssetID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UsageDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Action { get; set; } = null!;

    public int FiscalYear { get; set; }

    public int FiscalPeriod { get; set; }

    public int Usage { get; set; }

    public int? QtyTransaction { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("AssetID")]
    [InverseProperty("AssetMeter")]
    public virtual Assets Asset { get; set; } = null!;

    [ForeignKey("FiscalYear, FiscalPeriod")]
    [InverseProperty("AssetMeter")]
    public virtual FiscalPeriodDt FiscalPeriodDt { get; set; } = null!;
}
