using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ProcessDate", "DrugDispensingNo", "SequenceNo")]
public partial class IncentiveMedication
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime ProcessDate { get; set; }

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DrugDispensingNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ParamedicID { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string PatientName { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal COGSAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DrugDispensingNo")]
    [InverseProperty("IncentiveMedication")]
    public virtual DrugDispensingHd DrugDispensingNoNavigation { get; set; } = null!;
}
