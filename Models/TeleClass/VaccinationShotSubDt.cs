using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo", "DetailSubNo")]
public partial class VaccinationShotSubDt
{
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string DetailSubNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string VaccinationCode { get; set; } = null!;

    public int ItemID { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ChargesQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal DispenseQty { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string InventoryUnitCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCInjectionSite { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCFundingSource { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VaccineLotNo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsSelectedDt { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCFundingSource")]
    [InverseProperty("VaccinationShotSubDtGCFundingSourceNavigation")]
    public virtual sysGeneralCode? GCFundingSourceNavigation { get; set; }

    [ForeignKey("GCInjectionSite")]
    [InverseProperty("VaccinationShotSubDtGCInjectionSiteNavigation")]
    public virtual sysGeneralCode GCInjectionSiteNavigation { get; set; } = null!;

    [ForeignKey("InventoryUnitCode")]
    [InverseProperty("VaccinationShotSubDt")]
    public virtual ItemUnit InventoryUnitCodeNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("VaccinationShotSubDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("VaccinationShotSubDt")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("VaccinationCode")]
    [InverseProperty("VaccinationShotSubDt")]
    public virtual Vaccination VaccinationCodeNavigation { get; set; } = null!;

    [InverseProperty("VaccinationShotSubDt")]
    public virtual ICollection<VaccinationShotDt> VaccinationShotDt { get; set; } = new List<VaccinationShotDt>();

    [ForeignKey("RegistrationNo, SequenceNo")]
    [InverseProperty("VaccinationShotSubDt")]
    public virtual VaccinationShotHd VaccinationShotHd { get; set; } = null!;
}
