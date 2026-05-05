using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class VitalSignType
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string VitalSignCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string VitalSignName { get; set; } = null!;

    [StringLength(35)]
    [Unicode(false)]
    public string ShortName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string VitalSignLabel { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ValueType { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCValueCodeID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string VitalSignUnit { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? UnitOfMeasureCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MinNormalValue { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MaxNormalValue { get; set; }

    public byte DisplayOrder { get; set; }

    public int DisplayColor { get; set; }

    public bool IsDisplayInChart { get; set; }

    public bool IsUsedBySystem { get; set; }

    public bool IsNumericValue { get; set; }

    public bool IsHasNormalValue { get; set; }

    public bool IsSpecialIndicator { get; set; }

    public bool IsBySpecialty { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SpecialtyCode { get; set; }

    public bool? IsDisplayInSOAP { get; set; }

    public bool IsFormula { get; set; }

    public bool? IsComponenFormula { get; set; }

    [Unicode(false)]
    public string? Formula { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCValueCodeID")]
    [InverseProperty("VitalSignType")]
    public virtual sysGeneralCode? GCValueCode { get; set; }

    [InverseProperty("VitalSignCodeNavigation")]
    public virtual ICollection<GuidelineDtItem> GuidelineDtItem { get; set; } = new List<GuidelineDtItem>();

    [InverseProperty("VitalSignCodeNavigation")]
    public virtual ICollection<JobOrderDtMonitoring> JobOrderDtMonitoring { get; set; } = new List<JobOrderDtMonitoring>();

    [InverseProperty("VitalSignCodeNavigation")]
    public virtual ICollection<MonitoringAdministration> MonitoringAdministration { get; set; } = new List<MonitoringAdministration>();

    [ForeignKey("SpecialtyCode")]
    [InverseProperty("VitalSignType")]
    public virtual Specialty? SpecialtyCodeNavigation { get; set; }

    [InverseProperty("VitalSignCodeNavigation")]
    public virtual ICollection<SpecialtyVitalSign> SpecialtyVitalSign { get; set; } = new List<SpecialtyVitalSign>();

    [ForeignKey("UnitOfMeasureCode")]
    [InverseProperty("VitalSignType")]
    public virtual UnitOfMeasure? UnitOfMeasureCodeNavigation { get; set; }

    [InverseProperty("VitalSignCodeNavigation")]
    public virtual ICollection<VitalSignCodeVs3> VitalSignCodeVs3 { get; set; } = new List<VitalSignCodeVs3>();

    [InverseProperty("VitalSignCodeNavigation")]
    public virtual ICollection<VitalSignDt> VitalSignDt { get; set; } = new List<VitalSignDt>();

    [InverseProperty("VitalSignCodeNavigation")]
    public virtual ICollection<VitalSignDtFromVs3> VitalSignDtFromVs3 { get; set; } = new List<VitalSignDtFromVs3>();

    [InverseProperty("VitalSignCodeNavigation")]
    public virtual ICollection<VitalSignValueVs3> VitalSignValueVs3 { get; set; } = new List<VitalSignValueVs3>();
}
