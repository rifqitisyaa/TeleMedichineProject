using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ViewEMRLog
{
    [Key]
    public long LogID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCReasonToViewEMR { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Comment { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string UserID { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LogDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCReasonToViewEMR")]
    [InverseProperty("ViewEMRLog")]
    public virtual sysGeneralCode GCReasonToViewEMRNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("ViewEMRLog")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
