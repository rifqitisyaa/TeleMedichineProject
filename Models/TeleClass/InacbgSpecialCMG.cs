using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo", "GCGrouperTitle", "CMGCode")]
public partial class InacbgSpecialCMG
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCGrouperTitle { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string CMGCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string CMGName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo, SequenceNo, GCGrouperTitle")]
    [InverseProperty("InacbgSpecialCMG")]
    public virtual InacbgGrouper InacbgGrouper { get; set; } = null!;
}
