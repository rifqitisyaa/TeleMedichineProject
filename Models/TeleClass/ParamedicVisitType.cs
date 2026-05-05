using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ParamedicID", "ServiceUnitID", "VisitTypeCode")]
public partial class ParamedicVisitType
{
    [Key]
    public int ParamedicID { get; set; }

    [Key]
    public int ServiceUnitID { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string VisitTypeCode { get; set; } = null!;

    public byte VisitDuration { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ParamedicID")]
    [InverseProperty("ParamedicVisitType")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("ParamedicVisitType")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("VisitTypeCode")]
    [InverseProperty("ParamedicVisitType")]
    public virtual VisitType VisitTypeCodeNavigation { get; set; } = null!;
}
