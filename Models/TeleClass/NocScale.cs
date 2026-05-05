using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NocScale
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string NocScaleCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string NocScale1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string NocScale2 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string NocScale3 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string NocScale4 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string NocScale5 { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string NocScaleDefinition { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("NocScaleCodeNavigation")]
    public virtual ICollection<NocIndicator> NocIndicator { get; set; } = new List<NocIndicator>();
}
