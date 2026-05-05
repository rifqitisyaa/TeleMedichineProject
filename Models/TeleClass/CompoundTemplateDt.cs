using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("TemplateCode", "SequenceNo")]
public partial class CompoundTemplateDt
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string TemplateCode { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ParentID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CompoundQty { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? ResultQty { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? RFlag { get; set; }

    public bool? IsByDosage { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("CompoundTemplateDt")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("TemplateCode")]
    [InverseProperty("CompoundTemplateDt")]
    public virtual CompoundTemplateHd TemplateCodeNavigation { get; set; } = null!;
}
