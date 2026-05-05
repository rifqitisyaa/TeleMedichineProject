using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class ReferToConsult
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ConsultDateTime { get; set; }

    public int ParamedicIDFrom { get; set; }

    public int ParamedicIDTo { get; set; }

    [Unicode(false)]
    public string ConsultRemark { get; set; } = null!;

    [Unicode(false)]
    public string? ResponseRemark { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? GCConsultType { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ConsultReferenceNo { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ResponseReferenceNo { get; set; }

    public bool IsClosed { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ParamedicIDFrom")]
    [InverseProperty("ReferToConsultParamedicIDFromNavigation")]
    public virtual Paramedic ParamedicIDFromNavigation { get; set; } = null!;

    [ForeignKey("ParamedicIDTo")]
    [InverseProperty("ReferToConsultParamedicIDToNavigation")]
    public virtual Paramedic ParamedicIDToNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("ReferToConsult")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
