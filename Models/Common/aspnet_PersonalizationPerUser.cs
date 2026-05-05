using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

[Index("UserId", "PathId", Name = "aspnet_PersonalizationPerUser_ncindex2", IsUnique = true)]
public partial class aspnet_PersonalizationPerUser
{
    [Key]
    public Guid Id { get; set; }

    public Guid? PathId { get; set; }

    public Guid? UserId { get; set; }

    [Column(TypeName = "image")]
    public byte[] PageSettings { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDate { get; set; }

    [ForeignKey("PathId")]
    [InverseProperty("aspnet_PersonalizationPerUser")]
    public virtual aspnet_Paths? Path { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("aspnet_PersonalizationPerUser")]
    public virtual aspnet_Users? User { get; set; }
}
