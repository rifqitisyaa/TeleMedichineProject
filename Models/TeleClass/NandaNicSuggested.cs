using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("NandaCode", "NicCode")]
public partial class NandaNicSuggested
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string NandaCode { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string NicCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("NandaCode")]
    [InverseProperty("NandaNicSuggested")]
    public virtual Nanda NandaCodeNavigation { get; set; } = null!;

    [ForeignKey("NicCode")]
    [InverseProperty("NandaNicSuggested")]
    public virtual Nic NicCodeNavigation { get; set; } = null!;
}
