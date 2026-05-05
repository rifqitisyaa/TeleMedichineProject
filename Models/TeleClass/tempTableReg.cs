using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tempTableReg
{
    [StringLength(100)]
    [Unicode(false)]
    public string? regno { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? seqNo { get; set; }
}
