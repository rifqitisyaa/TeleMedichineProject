using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class aspnet_PersonalizationAllUsers
{
    [Key]
    public Guid PathId { get; set; }

    [Column(TypeName = "image")]
    public byte[] PageSettings { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDate { get; set; }

    [ForeignKey("PathId")]
    [InverseProperty("aspnet_PersonalizationAllUsers")]
    public virtual aspnet_Paths Path { get; set; } = null!;
}
