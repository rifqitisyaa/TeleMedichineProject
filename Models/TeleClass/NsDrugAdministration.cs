using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("DetailId", "JobOrderNo", "SequenceNo", "ItemID", "AdministrationDateTime")]
public partial class NsDrugAdministration
{
    [Key]
    public long DetailId { get; set; }

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    public int ItemID { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime AdministrationDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActualDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDrugStatus { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? GivenBy { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DetailId")]
    [InverseProperty("NsDrugAdministration")]
    public virtual NurseShiftTransferHistoryDt Detail { get; set; } = null!;
}
