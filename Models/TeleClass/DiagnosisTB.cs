using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DiagnosisTB
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string DiagnosisCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string DiagnosisName { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? AlternateDiagnosisName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DiagnosisNameCustom { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DTDNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ICDBlockID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? InfectiousDiseaseCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LokasiAnatomi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TipeDiagnosis { get; set; }

    public bool IsDisease { get; set; }

    public bool IsChronicDisease { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }

    [ForeignKey("DTDNo")]
    [InverseProperty("DiagnosisTB")]
    public virtual DTD? DTDNoNavigation { get; set; }

    [ForeignKey("ICDBlockID")]
    [InverseProperty("DiagnosisTB")]
    public virtual ICDBlock? ICDBlock { get; set; }

    [ForeignKey("InfectiousDiseaseCode")]
    [InverseProperty("DiagnosisTB")]
    public virtual InfectiousDisease? InfectiousDiseaseCodeNavigation { get; set; }
}
