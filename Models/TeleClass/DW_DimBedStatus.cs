using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimBedStatus
{
    [Key]
    public int BedStatusID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string BedStatusCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string BedStatusName { get; set; } = null!;

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("BedStatus")]
    public virtual ICollection<DW_FactBedCensus> DW_FactBedCensus { get; set; } = new List<DW_FactBedCensus>();
}
