using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class IDNT
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DomainCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? DomainName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDomainType { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
