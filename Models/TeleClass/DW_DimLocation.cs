using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimLocation
{
    [Key]
    public int LocationId { get; set; }

    public int? LocationIdOri { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LocationCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string LocationName { get; set; } = null!;

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("Location")]
    public virtual ICollection<DW_FactBalanceStock> DW_FactBalanceStock { get; set; } = new List<DW_FactBalanceStock>();

    [InverseProperty("Location")]
    public virtual ICollection<DW_FactFEFOIn> DW_FactFEFOIn { get; set; } = new List<DW_FactFEFOIn>();

    [InverseProperty("Location")]
    public virtual ICollection<DW_FactFEFOInPeriode> DW_FactFEFOInPeriode { get; set; } = new List<DW_FactFEFOInPeriode>();

    [InverseProperty("Location")]
    public virtual ICollection<DW_FactFEFOOut> DW_FactFEFOOut { get; set; } = new List<DW_FactFEFOOut>();

    [InverseProperty("Location")]
    public virtual ICollection<DW_FactFIFOIn> DW_FactFIFOIn { get; set; } = new List<DW_FactFIFOIn>();

    [InverseProperty("Location")]
    public virtual ICollection<DW_FactFIFOOut> DW_FactFIFOOut { get; set; } = new List<DW_FactFIFOOut>();
}
