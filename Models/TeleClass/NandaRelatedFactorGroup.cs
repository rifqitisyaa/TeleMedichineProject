using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NandaRelatedFactorGroup
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string NandaRelatedFactorGroupCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string NandaRelatedFactorGroupName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("NandaRelatedFactorGroupCodeNavigation")]
    public virtual ICollection<NandaRelatedFactor> NandaRelatedFactor { get; set; } = new List<NandaRelatedFactor>();
}
