using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NicDomain
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string NicDomainCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string NicDomainName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("NicDomainCodeNavigation")]
    public virtual ICollection<NicClass> NicClass { get; set; } = new List<NicClass>();
}
