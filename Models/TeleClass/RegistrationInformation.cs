using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class RegistrationInformation
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string RegistrationPreferredName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? AppointmentNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("RegistrationInformation")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
