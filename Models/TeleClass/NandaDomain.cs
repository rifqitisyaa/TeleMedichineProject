using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NandaDomain
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string NandaDomainCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string NandaDomainName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("NandaDomainCodeNavigation")]
    public virtual ICollection<NandaClass> NandaClass { get; set; } = new List<NandaClass>();
}
