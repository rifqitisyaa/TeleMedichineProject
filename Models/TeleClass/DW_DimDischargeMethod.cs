using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimDischargeMethod
{
    [Key]
    public int DischargeMethodID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string DischargeMethodCode { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string DischargeMethodName { get; set; } = null!;

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("DischargeMethod")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinance { get; set; } = new List<DW_FactMedicalRecordFinance>();
}
