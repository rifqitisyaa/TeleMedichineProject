using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class MonthlyHospitalPerformance
{
    [Key]
    public int Id { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string PeriodId { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string PeriodLabel { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ServiceUnitName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string DepartmentName { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalRevenue { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalPatient { get; set; }
}
