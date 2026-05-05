using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("TemplateCode", "SequenceNo")]
public partial class NandaTemplateDt
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string TemplateCode { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string NandaCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("NandaCode")]
    [InverseProperty("NandaTemplateDt")]
    public virtual Nanda NandaCodeNavigation { get; set; } = null!;

    [ForeignKey("TemplateCode")]
    [InverseProperty("NandaTemplateDt")]
    public virtual NandaTemplateHd TemplateCodeNavigation { get; set; } = null!;
}
