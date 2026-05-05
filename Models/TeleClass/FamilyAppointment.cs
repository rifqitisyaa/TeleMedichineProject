using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("PrimaryUserSSN", "FamilyMemberUserSSN", Name = "UQ_Relationship", IsUnique = true)]
public partial class FamilyAppointment
{
    [Key]
    public int FamilyId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PrimaryUserSSN { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string FamilyMemberUserSSN { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string RelationshipType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }
}
