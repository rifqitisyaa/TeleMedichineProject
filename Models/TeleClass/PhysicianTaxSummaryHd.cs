using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("Period", "ParamedicId")]
public partial class PhysicianTaxSummaryHd
{
    [Key]
    [StringLength(6)]
    [Unicode(false)]
    public string Period { get; set; } = null!;

    [Key]
    public int ParamedicId { get; set; }

    public bool TaxRegistrant { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal AccumulatedTransactionAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TransactionAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DPPAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PhysicianTaxAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PhysicianTaxAmountBefore { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal PhysicianTaxAmountCurrent { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ParamedicId")]
    [InverseProperty("PhysicianTaxSummaryHd")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [InverseProperty("PhysicianTaxSummaryHd")]
    public virtual ICollection<PhysicianTaxSummaryDt> PhysicianTaxSummaryDt { get; set; } = new List<PhysicianTaxSummaryDt>();
}
