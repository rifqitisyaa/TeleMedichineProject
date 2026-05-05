using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("Id", "ParameterCode")]
public partial class SpecialtyChartCategoryDt
{
    [Key]
    public int Id { get; set; }

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ParameterCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ParameterName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ParamaterType { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("SpecialtyChartCategoryDt")]
    public virtual SpecialityChartCategoryHd IdNavigation { get; set; } = null!;
}
