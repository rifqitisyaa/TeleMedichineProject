using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class temCaseTypeRegistration
{
    public int? temCaseTypeRegistrationID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CaseType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferralType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? register { get; set; }
}
