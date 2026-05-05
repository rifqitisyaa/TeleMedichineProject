using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ServiceUnitID", "ParamedicID")]
public partial class ServiceUnitParamedic
{
    [Key]
    public int ServiceUnitID { get; set; }

    [Key]
    public int ParamedicID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ParamedicID")]
    [InverseProperty("ServiceUnitParamedic")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("ServiceUnitParamedic")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;
}
