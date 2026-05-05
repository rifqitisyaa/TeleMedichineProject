using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("NandaCode", "NocCode")]
public partial class NandaNocSuggested
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string NandaCode { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string NocCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("NandaCode")]
    [InverseProperty("NandaNocSuggested")]
    public virtual Nanda NandaCodeNavigation { get; set; } = null!;

    [ForeignKey("NocCode")]
    [InverseProperty("NandaNocSuggested")]
    public virtual Noc NocCodeNavigation { get; set; } = null!;
}
