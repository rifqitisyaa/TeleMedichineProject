using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class MedicationReconciliationDtNew
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string MedicationName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Dosage { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? ServiceUnitAdmit { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ServiceUnitTransfer { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ServiceUnitDischarge { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Qty { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? RemainingQty { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Unit { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AdmitConsumeMethode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AdmitStatus { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TransferConsumeMethode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TransferStatus { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DischargeConsumeMethode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DischargeStatus { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FinalStatus { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? QtyPerDays { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? UsedQty { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }
}
