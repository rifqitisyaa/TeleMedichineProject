using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NicClass
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string NicClassCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string NicClassName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string NicDomainCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("NicClassCodeNavigation")]
    public virtual ICollection<Nic> Nic { get; set; } = new List<Nic>();

    [ForeignKey("NicDomainCode")]
    [InverseProperty("NicClass")]
    public virtual NicDomain NicDomainCodeNavigation { get; set; } = null!;
}
