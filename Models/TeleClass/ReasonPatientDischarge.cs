using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ReasonPatientDischarge
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? Reason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatientDischargeDateTime { get; set; }

    [Unicode(false)]
    public string? CreatedBy { get; set; }
}
