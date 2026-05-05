using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "RegistrationNo", "SequenceNo")]
public partial class PatientDocument
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCDocumentType { get; set; } = null!;

    public DateOnly DocumentDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string DocumentName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCDocumentType")]
    [InverseProperty("PatientDocument")]
    public virtual sysGeneralCode GCDocumentTypeNavigation { get; set; } = null!;

    [ForeignKey("MedicalNo")]
    [InverseProperty("PatientDocument")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;

    [InverseProperty("PatientDocument")]
    public virtual ICollection<PatientDocumentDetail> PatientDocumentDetail { get; set; } = new List<PatientDocumentDetail>();

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PatientDocument")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("PatientDocument")]
    public virtual Site? SiteCodeNavigation { get; set; }
}
