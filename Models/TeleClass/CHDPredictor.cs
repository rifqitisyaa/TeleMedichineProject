using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class CHDPredictor
{
    [Key]
    public int CHDPredictorID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCSex { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCCHDPredictorType { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Value1 { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Value2 { get; set; } = null!;

    public int? LDLPts { get; set; }

    public int? CholPts { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCCHDPredictorType")]
    [InverseProperty("CHDPredictorGCCHDPredictorTypeNavigation")]
    public virtual sysGeneralCode GCCHDPredictorTypeNavigation { get; set; } = null!;

    [ForeignKey("GCSex")]
    [InverseProperty("CHDPredictorGCSexNavigation")]
    public virtual sysGeneralCode GCSexNavigation { get; set; } = null!;

    [InverseProperty("CholesterolValueNavigation")]
    public virtual ICollection<PatientCHDRisk> PatientCHDRiskCholesterolValueNavigation { get; set; } = new List<PatientCHDRisk>();

    [InverseProperty("DiabetesValueNavigation")]
    public virtual ICollection<PatientCHDRisk> PatientCHDRiskDiabetesValueNavigation { get; set; } = new List<PatientCHDRisk>();

    [InverseProperty("HDLValueNavigation")]
    public virtual ICollection<PatientCHDRisk> PatientCHDRiskHDLValueNavigation { get; set; } = new List<PatientCHDRisk>();

    [InverseProperty("LDLValueNavigation")]
    public virtual ICollection<PatientCHDRisk> PatientCHDRiskLDLValueNavigation { get; set; } = new List<PatientCHDRisk>();

    [InverseProperty("SmokerValueNavigation")]
    public virtual ICollection<PatientCHDRisk> PatientCHDRiskSmokerValueNavigation { get; set; } = new List<PatientCHDRisk>();
}
