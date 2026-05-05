using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tmpYankesICD10
{
    public string CODE { get; set; } = null!;

    public string DESCRIPTION { get; set; } = null!;
}
