using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Class
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ClassName { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string ShortName { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string Initial { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ClassCategoryCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCClassRL { get; set; }

    public byte ClassLevel { get; set; }

    public bool IsAdministrationChargeByClass { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MinAdministrationCharge { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MaxAdministrationCharge { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal PercentageAdministrationCharge { get; set; }

    public int? PhysicianChargesItemID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? DisplayPrice { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PictureFileName { get; set; }

    public int? PatientPerRoomQty { get; set; }

    public bool? IsHasAC { get; set; }

    public bool? IsHasPrivateBathRoom { get; set; }

    public bool? IsHasRefrigerator { get; set; }

    public bool? IsHasTV { get; set; }

    public bool? IsHasWifi { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("ClassCodeNavigation")]
    public virtual ICollection<AnalyzeOfCensus> AnalyzeOfCensus { get; set; } = new List<AnalyzeOfCensus>();

    [InverseProperty("ClassCodeNavigation")]
    public virtual ICollection<Bed> Bed { get; set; } = new List<Bed>();

    [InverseProperty("ClassCodeNavigation")]
    public virtual ICollection<BedReservation> BedReservation { get; set; } = new List<BedReservation>();

    [InverseProperty("FromChargeClassCodeNavigation")]
    public virtual ICollection<BedTransfer> BedTransferFromChargeClassCodeNavigation { get; set; } = new List<BedTransfer>();

    [InverseProperty("FromClassCodeNavigation")]
    public virtual ICollection<BedTransfer> BedTransferFromClassCodeNavigation { get; set; } = new List<BedTransfer>();

    [InverseProperty("ToChargeClassCodeNavigation")]
    public virtual ICollection<BedTransfer> BedTransferToChargeClassCodeNavigation { get; set; } = new List<BedTransfer>();

    [InverseProperty("ToClassCodeNavigation")]
    public virtual ICollection<BedTransfer> BedTransferToClassCodeNavigation { get; set; } = new List<BedTransfer>();

    [InverseProperty("ClassCodeNavigation")]
    public virtual ICollection<CensusHistory> CensusHistory { get; set; } = new List<CensusHistory>();

    [ForeignKey("ClassCategoryCode")]
    [InverseProperty("Class")]
    public virtual ClassCategory ClassCategoryCodeNavigation { get; set; } = null!;

    [InverseProperty("ClassCodeNavigation")]
    public virtual ICollection<CustomerAkomodasiKamar> CustomerAkomodasiKamar { get; set; } = new List<CustomerAkomodasiKamar>();

    [InverseProperty("ClassCodeNavigation")]
    public virtual ICollection<CustomerClass> CustomerClass { get; set; } = new List<CustomerClass>();

    [InverseProperty("ClassCodeNavigation")]
    public virtual ICollection<CustomerContractClass> CustomerContractClass { get; set; } = new List<CustomerContractClass>();

    [ForeignKey("GCClassRL")]
    [InverseProperty("Class")]
    public virtual sysGeneralCode? GCClassRLNavigation { get; set; }

    [InverseProperty("UpgradeClassCodeNavigation")]
    public virtual ICollection<InacbgClaim> InacbgClaim { get; set; } = new List<InacbgClaim>();

    [InverseProperty("ClassCodeNavigation")]
    public virtual InterimBillLimit? InterimBillLimit { get; set; }

    [InverseProperty("ClassCodeNavigation")]
    public virtual ICollection<PhysicianChargesByClass> PhysicianChargesByClass { get; set; } = new List<PhysicianChargesByClass>();

    [ForeignKey("PhysicianChargesItemID")]
    [InverseProperty("Class")]
    public virtual Item? PhysicianChargesItem { get; set; }

    [InverseProperty("ChargeClassCodeAfterNavigation")]
    public virtual ICollection<RecalculationHd> RecalculationHdChargeClassCodeAfterNavigation { get; set; } = new List<RecalculationHd>();

    [InverseProperty("ChargeClassCodeBeforeNavigation")]
    public virtual ICollection<RecalculationHd> RecalculationHdChargeClassCodeBeforeNavigation { get; set; } = new List<RecalculationHd>();

    [InverseProperty("CoveredClassCodeAfterNavigation")]
    public virtual ICollection<RecalculationHd> RecalculationHdCoveredClassCodeAfterNavigation { get; set; } = new List<RecalculationHd>();

    [InverseProperty("CoveredClassCodeBeforeNavigation")]
    public virtual ICollection<RecalculationHd> RecalculationHdCoveredClassCodeBeforeNavigation { get; set; } = new List<RecalculationHd>();

    [InverseProperty("ChargeClassCodeNavigation")]
    public virtual ICollection<Registration> RegistrationChargeClassCodeNavigation { get; set; } = new List<Registration>();

    [InverseProperty("ClassCodeNavigation")]
    public virtual ICollection<Registration> RegistrationClassCodeNavigation { get; set; } = new List<Registration>();

    [InverseProperty("CoveredClassCodeNavigation")]
    public virtual ICollection<Registration> RegistrationCoveredClassCodeNavigation { get; set; } = new List<Registration>();

    [InverseProperty("OriginalChargeClassCodeNavigation")]
    public virtual ICollection<Registration> RegistrationOriginalChargeClassCodeNavigation { get; set; } = new List<Registration>();

    [InverseProperty("OriginalClassCodeNavigation")]
    public virtual ICollection<Registration> RegistrationOriginalClassCodeNavigation { get; set; } = new List<Registration>();

    [InverseProperty("ClassCodeNavigation")]
    public virtual ICollection<TemplateTariffDt> TemplateTariffDt { get; set; } = new List<TemplateTariffDt>();

    [InverseProperty("ClassCodeNavigation")]
    public virtual ICollection<TemplateTariffHd> TemplateTariffHd { get; set; } = new List<TemplateTariffHd>();

    [InverseProperty("ChargeClassCodeNavigation")]
    public virtual ICollection<TransactionChargesHd> TransactionChargesHdChargeClassCodeNavigation { get; set; } = new List<TransactionChargesHd>();

    [InverseProperty("ClassCodeNavigation")]
    public virtual ICollection<TransactionChargesHd> TransactionChargesHdClassCodeNavigation { get; set; } = new List<TransactionChargesHd>();
}
