using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PrescriptionTemplateHd
{
    [Key]
    public int TemplateId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string TemplateName { get; set; } = null!;

    public int ParamedicId { get; set; }

    public bool IsReviewed { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ParamedicId")]
    [InverseProperty("PrescriptionTemplateHd")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [InverseProperty("Template")]
    public virtual ICollection<PrescriptionTemplateDt> PrescriptionTemplateDt { get; set; } = new List<PrescriptionTemplateDt>();
}
