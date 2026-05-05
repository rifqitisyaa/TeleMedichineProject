using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimNationality
{
    [Key]
    public int NationalityID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string NationalityCode { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string NationalityName { get; set; } = null!;

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("Nationality")]
    public virtual ICollection<DW_DimParamedic> DW_DimParamedic { get; set; } = new List<DW_DimParamedic>();

    [InverseProperty("Nationality")]
    public virtual ICollection<DW_DimPatient> DW_DimPatient { get; set; } = new List<DW_DimPatient>();
}
