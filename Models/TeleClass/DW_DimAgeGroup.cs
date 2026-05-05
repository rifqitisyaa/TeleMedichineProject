using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimAgeGroup
{
    [Key]
    public int AgeGroupID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string AgeGroupName { get; set; } = null!;

    public int FromYear { get; set; }

    public int FromMonth { get; set; }

    public int FromDay { get; set; }

    public int ToYear { get; set; }

    public int ToMonth { get; set; }

    public int ToDay { get; set; }

    [InverseProperty("AgeGroup")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinance { get; set; } = new List<DW_FactMedicalRecordFinance>();
}
