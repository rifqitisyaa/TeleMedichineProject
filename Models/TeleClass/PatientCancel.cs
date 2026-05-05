using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PatientCancel
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Reason { get; set; }

    public int? ParamedicID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [ForeignKey("ParamedicID")]
    [InverseProperty("PatientCancel")]
    public virtual Paramedic? Paramedic { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PatientCancel")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
