using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DigikesRegistration
{
    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    public bool IsSendToDigikes { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SendDateTime { get; set; }
}
