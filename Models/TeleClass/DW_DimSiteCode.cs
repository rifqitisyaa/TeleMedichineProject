using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimSiteCode
{
    [Key]
    public int SiteID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string SiteName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSiteGroup { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SiteGroupName { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("Site")]
    public virtual ICollection<DW_FactAPMovement> DW_FactAPMovement { get; set; } = new List<DW_FactAPMovement>();

    [InverseProperty("Site")]
    public virtual ICollection<DW_FactBalanceStock> DW_FactBalanceStock { get; set; } = new List<DW_FactBalanceStock>();

    [InverseProperty("Site")]
    public virtual ICollection<DW_FactBedCensus> DW_FactBedCensus { get; set; } = new List<DW_FactBedCensus>();

    [InverseProperty("Site")]
    public virtual ICollection<DW_FactFEFOIn> DW_FactFEFOIn { get; set; } = new List<DW_FactFEFOIn>();

    [InverseProperty("Site")]
    public virtual ICollection<DW_FactFEFOInPeriode> DW_FactFEFOInPeriode { get; set; } = new List<DW_FactFEFOInPeriode>();

    [InverseProperty("Site")]
    public virtual ICollection<DW_FactFEFOOut> DW_FactFEFOOut { get; set; } = new List<DW_FactFEFOOut>();

    [InverseProperty("Site")]
    public virtual ICollection<DW_FactFIFOIn> DW_FactFIFOIn { get; set; } = new List<DW_FactFIFOIn>();

    [InverseProperty("Site")]
    public virtual ICollection<DW_FactFIFOInPeriode> DW_FactFIFOInPeriode { get; set; } = new List<DW_FactFIFOInPeriode>();

    [InverseProperty("Site")]
    public virtual ICollection<DW_FactFIFOOut> DW_FactFIFOOut { get; set; } = new List<DW_FactFIFOOut>();

    [InverseProperty("Site")]
    public virtual ICollection<DW_FactMaterialCost> DW_FactMaterialCost { get; set; } = new List<DW_FactMaterialCost>();

    [InverseProperty("Site")]
    public virtual ICollection<DW_FactMedicalRecordFinance> DW_FactMedicalRecordFinance { get; set; } = new List<DW_FactMedicalRecordFinance>();

    [InverseProperty("Site")]
    public virtual ICollection<DW_FactPharmacySales> DW_FactPharmacySales { get; set; } = new List<DW_FactPharmacySales>();
}
