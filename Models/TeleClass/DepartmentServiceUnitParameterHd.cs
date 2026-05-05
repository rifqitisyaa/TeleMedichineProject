using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DepartmentServiceUnitParameterHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ParameterCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ParameterName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? TagFieldDescription { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("ParameterCodeNavigation")]
    public virtual ICollection<DepartmentServiceUnitParameterDt> DepartmentServiceUnitParameterDt { get; set; } = new List<DepartmentServiceUnitParameterDt>();
}
