using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class RL314MasterData
{
    public int? ColNo { get; set; }

    [Unicode(false)]
    public string? ColType { get; set; }

    public int? Year { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? GCReferralType { get; set; }

    [Unicode(false)]
    public string? ReferralHealthCare { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SpecialtyCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReferralNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }
}
