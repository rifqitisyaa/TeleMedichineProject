using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_SiencePatientRegistration
{
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? Since { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateOfBirth { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Sex { get; set; } = null!;
}
