using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class TmpVitalsignType
{
    [StringLength(512)]
    [Unicode(false)]
    public string? VitalSignCode { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? VitalSignName { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? ShortName { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? VitalSignLabel { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? ValueType { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? GCValueCodeID { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? VitalSignUnit { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? UnitOfMeasureCode { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? MinNormalValue { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? MaxNormalValue { get; set; }

    public int? DisplayOrder { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? DisplayColor { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsDisplayInChart { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsUsedBySystem { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsNumericValue { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsHasNormalValue { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsSpecialIndicator { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsBySpecialty { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? SpecialtyCode { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsDisplayInSOAP { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsFormula { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsComponenFormula { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? Formula { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsActive { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? IsDeleted { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? LastUpdatedDateTime { get; set; }
}
