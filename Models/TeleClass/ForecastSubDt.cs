using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ForecastNo", "SequenceNo")]
public partial class ForecastSubDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ForecastNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? CalculatedQty { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? RevisedQty { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? ForecastQty { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("ForecastSubDt")]
    public virtual ICollection<ForecastDt> ForecastDt { get; set; } = new List<ForecastDt>();

    [ForeignKey("ForecastNo")]
    [InverseProperty("ForecastSubDt")]
    public virtual ForecastHd ForecastNoNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("ForecastSubDt")]
    public virtual Item Item { get; set; } = null!;
}
