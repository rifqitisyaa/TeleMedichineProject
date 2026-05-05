using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DW_DimSupplierType
{
    [Key]
    public int SupplierTypeID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string SupplierTypeCode { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string SupplierTypeName { get; set; } = null!;

    public DateOnly? EffectiveDate { get; set; }

    [InverseProperty("SupplierType")]
    public virtual ICollection<DW_DimSupplier> DW_DimSupplier { get; set; } = new List<DW_DimSupplier>();
}
