using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class InformedConsent
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MenuId { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string InformedConsentGroup { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDatetime { get; set; }

    [ForeignKey("MenuId")]
    [InverseProperty("InformedConsent")]
    public virtual sysMenu Menu { get; set; } = null!;
}
