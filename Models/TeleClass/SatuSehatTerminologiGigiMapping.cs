using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ID", "Type")]
public partial class SatuSehatTerminologiGigiMapping
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string ID { get; set; } = null!;

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? CodingSystem { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CodingCode { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? CodingDisplay { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceCode { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
