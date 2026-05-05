using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DrugDispensingHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DrugDispensingNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public int ParamedicID { get; set; }

    public int ServiceUnitID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DrugDispensingDate { get; set; }

    public int LocationID { get; set; }

    public bool IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCOrderType { get; set; }

    public int? Iteration { get; set; }

    public bool IsComplete { get; set; }

    public bool IsSendToAutopack { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("DrugDispensingNoNavigation")]
    public virtual ICollection<DrugDispensingDt> DrugDispensingDt { get; set; } = new List<DrugDispensingDt>();

    [ForeignKey("GCOrderType")]
    [InverseProperty("DrugDispensingHd")]
    public virtual sysGeneralCode? GCOrderTypeNavigation { get; set; }

    [InverseProperty("DrugDispensingNoNavigation")]
    public virtual ICollection<IncentiveMedication> IncentiveMedication { get; set; } = new List<IncentiveMedication>();

    [ForeignKey("LocationID")]
    [InverseProperty("DrugDispensingHd")]
    public virtual Location Location { get; set; } = null!;

    [ForeignKey("ParamedicID")]
    [InverseProperty("DrugDispensingHd")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("DrugDispensingHd")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("DrugDispensingHd")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("DrugDispensingHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("DrugDispensingHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
