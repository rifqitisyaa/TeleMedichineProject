using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimEmploymentStatus
{
    [Key]
    public int EmploymentStatusID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string EmploymentStatusCode { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string EmployementStatusName { get; set; } = null!;

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("EmploymentStatus")]
    public virtual ICollection<DW_DimParamedic> DW_DimParamedic { get; set; } = new List<DW_DimParamedic>();
}
