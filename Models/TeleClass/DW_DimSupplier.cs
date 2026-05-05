using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimSupplier
{
    [Key]
    public int SupplierID { get; set; }

    public int BusinessPartnerID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string SupplierName { get; set; } = null!;

    public int SupplierTypeID { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("Supplier")]
    public virtual ICollection<DW_FactAPMovement> DW_FactAPMovement { get; set; } = new List<DW_FactAPMovement>();

    [ForeignKey("SupplierTypeID")]
    [InverseProperty("DW_DimSupplier")]
    public virtual DW_DimSupplierType SupplierType { get; set; } = null!;
}
