using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NocClass
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string NocClassCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string NocClassName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string NocDomainCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("NocClassCodeNavigation")]
    public virtual ICollection<Noc> Noc { get; set; } = new List<Noc>();

    [ForeignKey("NocDomainCode")]
    [InverseProperty("NocClass")]
    public virtual NocDomain NocDomainCodeNavigation { get; set; } = null!;
}
