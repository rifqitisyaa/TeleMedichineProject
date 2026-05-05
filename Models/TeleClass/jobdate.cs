using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class jobdate
{
    [Column(TypeName = "datetime")]
    public DateTime JobOrderDateTime { get; set; }
}
