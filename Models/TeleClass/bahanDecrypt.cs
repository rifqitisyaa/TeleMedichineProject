using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class bahanDecrypt
{
    [StringLength(3544)]
    [Unicode(false)]
    public string textd { get; set; } = null!;
}
