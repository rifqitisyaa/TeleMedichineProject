using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimClass
{
    [Key]
    public int ClassID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ClassName { get; set; } = null!;

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("Class")]
    public virtual ICollection<DW_FactBedCensus> DW_FactBedCensus { get; set; } = new List<DW_FactBedCensus>();

    [InverseProperty("ChargeClass")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinanceChargeClass { get; set; } = new List<DW_FactMedicalRecordFinance>();

    [InverseProperty("Class")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinanceClass { get; set; } = new List<DW_FactMedicalRecordFinance>();
}
