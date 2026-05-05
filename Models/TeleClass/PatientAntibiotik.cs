using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class PatientAntibiotik
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int GenericId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCStatus { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCStatus")]
    [InverseProperty("PatientAntibiotik")]
    public virtual sysGeneralCode GCStatusNavigation { get; set; } = null!;

    [ForeignKey("GenericId")]
    [InverseProperty("PatientAntibiotik")]
    public virtual ItemGeneric Generic { get; set; } = null!;

    [ForeignKey("MedicalNo")]
    [InverseProperty("PatientAntibiotik")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;
}
