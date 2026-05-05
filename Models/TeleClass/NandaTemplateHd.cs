using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NandaTemplateHd
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string TemplateCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string TemplateDescription { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("TemplateCodeNavigation")]
    public virtual ICollection<NandaTemplateDt> NandaTemplateDt { get; set; } = new List<NandaTemplateDt>();
}
