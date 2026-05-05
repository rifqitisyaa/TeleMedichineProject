using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ItemServiceMCURealizationHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string TransactionNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TransactionDate { get; set; }

    public int ServiceUnitID { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("TransactionNoNavigation")]
    public virtual ICollection<ItemServiceMCURealizationDt> ItemServiceMCURealizationDt { get; set; } = new List<ItemServiceMCURealizationDt>();

    [ForeignKey("RegistrationNo")]
    [InverseProperty("ItemServiceMCURealizationHd")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("ItemServiceMCURealizationHd")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("ItemServiceMCURealizationHd")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("ItemServiceMCURealizationHd")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
