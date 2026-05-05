using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_FactBedCensus
{
    [Key]
    public int ID { get; set; }

    public int DateID { get; set; }

    public int SiteID { get; set; }

    public int DepartmentID { get; set; }

    public int ServiceUnitID { get; set; }

    public int RoomID { get; set; }

    public int ClassID { get; set; }

    public int BedID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    public int BedStatusID { get; set; }

    public int? IPDays { get; set; }

    public int? CummulativeIPDays { get; set; }

    public int? AvailableBed { get; set; }

    public int? CummAvailableBed { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? BOR { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Amount { get; set; }

    [ForeignKey("BedID")]
    [InverseProperty("DW_FactBedCensus")]
    public virtual DW_DimBed Bed { get; set; } = null!;

    [ForeignKey("BedStatusID")]
    [InverseProperty("DW_FactBedCensus")]
    public virtual DW_DimBedStatus BedStatus { get; set; } = null!;

    [ForeignKey("ClassID")]
    [InverseProperty("DW_FactBedCensus")]
    public virtual DW_DimClass Class { get; set; } = null!;

    [ForeignKey("DateID")]
    [InverseProperty("DW_FactBedCensus")]
    public virtual DW_DimDate Date { get; set; } = null!;

    [ForeignKey("DepartmentID")]
    [InverseProperty("DW_FactBedCensus")]
    public virtual DW_DimDepartment Department { get; set; } = null!;

    [ForeignKey("RoomID")]
    [InverseProperty("DW_FactBedCensus")]
    public virtual DW_DimServiceRoom Room { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("DW_FactBedCensus")]
    public virtual DW_DimServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("SiteID")]
    [InverseProperty("DW_FactBedCensus")]
    public virtual DW_DimSiteCode Site { get; set; } = null!;
}
