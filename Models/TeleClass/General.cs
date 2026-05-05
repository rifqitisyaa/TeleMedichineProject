using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class General
{
    public int ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ProjectNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ItemName { get; set; } = null!;

    [Unicode(false)]
    public string ProblemName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string DepartmentName { get; set; } = null!;

    [Column(TypeName = "numeric(18, 0)")]
    public decimal JumlahPatient { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal TotalPatientMCU { get; set; }
}
