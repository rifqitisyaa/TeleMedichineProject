using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class PatientNotes
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCPatientNotesType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime NotesDateTime { get; set; }

    public int ParamedicID { get; set; }

    public int? ParamedicTo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCInstructionBy { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCRefferenceType { get; set; }

    public bool? IsNeedReviewed { get; set; }

    public bool? IsReviewed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCInstructionBy")]
    [InverseProperty("PatientNotesGCInstructionByNavigation")]
    public virtual sysGeneralCode? GCInstructionByNavigation { get; set; }

    [ForeignKey("GCPatientNotesType")]
    [InverseProperty("PatientNotesGCPatientNotesTypeNavigation")]
    public virtual sysGeneralCode GCPatientNotesTypeNavigation { get; set; } = null!;

    [ForeignKey("GCRefferenceType")]
    [InverseProperty("PatientNotesGCRefferenceTypeNavigation")]
    public virtual sysGeneralCode? GCRefferenceTypeNavigation { get; set; }

    [ForeignKey("ParamedicID")]
    [InverseProperty("PatientNotesParamedic")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [ForeignKey("ParamedicTo")]
    [InverseProperty("PatientNotesParamedicToNavigation")]
    public virtual Paramedic? ParamedicToNavigation { get; set; }

    [InverseProperty("PatientNotes")]
    public virtual ICollection<PatientPPAInstruction> PatientPPAInstruction { get; set; } = new List<PatientPPAInstruction>();

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PatientNotes")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("PatientNotes")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
