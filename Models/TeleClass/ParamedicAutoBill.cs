using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ParamedicID", "ItemID")]
public partial class ParamedicAutoBill
{
    [Key]
    public int ParamedicID { get; set; }

    [Key]
    public int ItemID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DepartmentCode { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("DepartmentCode")]
    [InverseProperty("ParamedicAutoBill")]
    public virtual Department? DepartmentCodeNavigation { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("ParamedicAutoBill")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ParamedicID")]
    [InverseProperty("ParamedicAutoBill")]
    public virtual Paramedic Paramedic { get; set; } = null!;
}
