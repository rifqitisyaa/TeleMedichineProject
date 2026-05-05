using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class PatientGuideLines
{
    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    public int ID { get; set; }

    public int? GuideLinesID { get; set; }

    [Unicode(false)]
    public string? Name { get; set; }

    public int? ParentID { get; set; }

    public bool? Status { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Physician { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Remark { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Type { get; set; }
}
