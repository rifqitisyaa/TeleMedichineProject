using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DrugReturnHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DrugReturnNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public DateOnly DrugReturnDate { get; set; }

    public int ServiceUnitID { get; set; }

    public int LocationID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDrugReturnReason { get; set; }

    public bool? IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    public bool? IsCorrection { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("DrugReturnNoNavigation")]
    public virtual ICollection<DrugReturnDt> DrugReturnDt { get; set; } = new List<DrugReturnDt>();

    [ForeignKey("GCDrugReturnReason")]
    [InverseProperty("DrugReturnHd")]
    public virtual sysGeneralCode? GCDrugReturnReasonNavigation { get; set; }

    [ForeignKey("LocationID")]
    [InverseProperty("DrugReturnHd")]
    public virtual Location Location { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("DrugReturnHd")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("DrugReturnHd")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("DrugReturnHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("DrugReturnHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
