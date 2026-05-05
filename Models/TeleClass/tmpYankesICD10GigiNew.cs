using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tmpYankesICD10GigiNew
{
    [Unicode(false)]
    public string CODE { get; set; } = null!;

    [Unicode(false)]
    public string DESCRIPTION { get; set; } = null!;
}
