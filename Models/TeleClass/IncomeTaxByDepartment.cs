using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class IncomeTaxByDepartment
{
    [Key]
    public int Id { get; set; }

    public int SiteDepartmentID { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal TaxPercentage { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCItemType { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemGroupCode { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LasUpdateDateTime { get; set; }

    [ForeignKey("GCItemType")]
    [InverseProperty("IncomeTaxByDepartment")]
    public virtual sysGeneralCode? GCItemTypeNavigation { get; set; }

    [ForeignKey("ItemGroupCode")]
    [InverseProperty("IncomeTaxByDepartment")]
    public virtual ItemGroup? ItemGroupCodeNavigation { get; set; }

    [ForeignKey("SiteDepartmentID")]
    [InverseProperty("IncomeTaxByDepartment")]
    public virtual SiteDepartment SiteDepartment { get; set; } = null!;
}
