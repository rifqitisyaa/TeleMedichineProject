using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TemplateOtherExam
{
    [Key]
    public int TemplateID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string TemplateName { get; set; } = null!;

    public int? ParamedicID { get; set; }

    public int? ItemID { get; set; }

    [Unicode(false)]
    public string Result { get; set; } = null!;

    [Unicode(false)]
    public string Summary { get; set; } = null!;

    [Unicode(false)]
    public string Recommendation { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemID")]
    [InverseProperty("TemplateOtherExam")]
    public virtual Item? Item { get; set; }

    [ForeignKey("ParamedicID")]
    [InverseProperty("TemplateOtherExam")]
    public virtual Paramedic? Paramedic { get; set; }
}
