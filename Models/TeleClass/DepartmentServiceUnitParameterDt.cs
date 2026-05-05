using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ParameterCode", "SequenceNo")]
public partial class DepartmentServiceUnitParameterDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ParameterCode { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ServiceUnitId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string TagField1 { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ParameterCode")]
    [InverseProperty("DepartmentServiceUnitParameterDt")]
    public virtual DepartmentServiceUnitParameterHd ParameterCodeNavigation { get; set; } = null!;

    [ForeignKey("ServiceUnitId")]
    [InverseProperty("DepartmentServiceUnitParameterDt")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;
}
