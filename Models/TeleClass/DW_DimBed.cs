using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimBed
{
    [Key]
    public int BedID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string BedCode { get; set; } = null!;

    public int? BedIDOri { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("Bed")]
    public virtual ICollection<DW_FactBedCensus> DW_FactBedCensus { get; set; } = new List<DW_FactBedCensus>();
}
