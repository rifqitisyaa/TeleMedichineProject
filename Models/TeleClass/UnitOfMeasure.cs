using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class UnitOfMeasure
{
    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string UnitOfMeasureCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string UnitOfMeasureName { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? AlternateUnitOfMeasureName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? UnitOfMeasureNameCustom { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReferenceCode { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("UnitOfMeasureCodeNavigation")]
    public virtual ICollection<VitalSignType> VitalSignType { get; set; } = new List<VitalSignType>();
}
