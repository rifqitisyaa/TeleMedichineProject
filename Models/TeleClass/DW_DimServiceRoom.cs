using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimServiceRoom
{
    [Key]
    public int RoomID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RoomCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RoomName { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("Room")]
    public virtual ICollection<DW_FactBedCensus> DW_FactBedCensus { get; set; } = new List<DW_FactBedCensus>();

    [InverseProperty("Room")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinance { get; set; } = new List<DW_FactMedicalRecordFinance>();
}
