using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NandaClass
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string NandaClassCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string NandaClassName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? NandaClassName2 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string NandaDomainCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("NandaDomainCode")]
    [InverseProperty("NandaClass")]
    public virtual NandaDomain NandaDomainCodeNavigation { get; set; } = null!;
}
