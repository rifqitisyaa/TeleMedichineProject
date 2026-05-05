using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tmpResultVS
{
    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(105)]
    [Unicode(false)]
    public string VitalSignCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string VitalSignValue { get; set; } = null!;
}
