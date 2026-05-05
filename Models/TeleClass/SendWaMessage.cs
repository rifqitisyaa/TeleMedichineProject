using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class SendWaMessage
{
    [StringLength(50)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MessageDateTime { get; set; }

    [Unicode(false)]
    public string? MessageText { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SendBy { get; set; }
}
