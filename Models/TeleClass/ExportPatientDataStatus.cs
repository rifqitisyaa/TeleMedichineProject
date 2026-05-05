using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ExportPatientDataStatus
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    public bool IsExported { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("ExportPatientDataStatus")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
