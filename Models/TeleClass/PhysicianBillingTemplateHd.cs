using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PhysicianBillingTemplateHd
{
    [Key]
    public int TemplateID { get; set; }

    [Unicode(false)]
    public string TemplateName { get; set; } = null!;

    public int? ParamedicID { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Template")]
    public virtual ICollection<PhysicianBillingTemplateDt> PhysicianBillingTemplateDt { get; set; } = new List<PhysicianBillingTemplateDt>();
}
