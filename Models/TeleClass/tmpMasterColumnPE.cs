using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tmpMasterColumnPE
{
    [StringLength(603)]
    [Unicode(false)]
    public string QuestionText { get; set; } = null!;

    public long? Ordering { get; set; }
}
