using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tmpResultPE
{
    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(603)]
    [Unicode(false)]
    public string QuestionText { get; set; } = null!;

    public string? AnswerText { get; set; }
}
