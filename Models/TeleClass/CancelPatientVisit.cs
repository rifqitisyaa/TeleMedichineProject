using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class CancelPatientVisit
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CancelDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCReason { get; set; } = null!;

    public int ServiceUnitID { get; set; }

    public int ParamedicID { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCReason")]
    [InverseProperty("CancelPatientVisit")]
    public virtual sysGeneralCode GCReasonNavigation { get; set; } = null!;

    [ForeignKey("ParamedicID")]
    [InverseProperty("CancelPatientVisit")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("CancelPatientVisit")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;
}
