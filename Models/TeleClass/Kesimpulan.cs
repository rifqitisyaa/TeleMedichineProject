using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class Kesimpulan
{
    [StringLength(50)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [Unicode(false)]
    public string? ProblemName { get; set; }

    [Unicode(false)]
    public string? ResultValue { get; set; }
}
