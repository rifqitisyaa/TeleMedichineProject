using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class PatientInjectDetail
{
    [StringLength(15)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastTime { get; set; }
}
