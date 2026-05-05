using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimDepartment
{
    [Key]
    public int DepartmentID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string DepartmentName { get; set; } = null!;

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("Department")]
    public virtual ICollection<DW_FactBedCensus> DW_FactBedCensus { get; set; } = new List<DW_FactBedCensus>();

    [InverseProperty("Department")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinance { get; set; } = new List<DW_FactMedicalRecordFinance>();
}
