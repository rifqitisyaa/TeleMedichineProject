using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NocDomain
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string NocDomainCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string NocDomainName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("NocDomainCodeNavigation")]
    public virtual ICollection<NocClass> NocClass { get; set; } = new List<NocClass>();
}
