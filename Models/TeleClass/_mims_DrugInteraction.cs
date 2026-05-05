using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class _mims_DrugInteraction
{
    [Key]
    public int DrugInteractionID { get; set; }

    public int? GenericID { get; set; }

    public int? InteractingGenericID { get; set; }

    public Guid? ReferenceID { get; set; }

    public Guid? InteractingReferenceID { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string AdverseEffect { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDrugInteractionSeverity { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCDrugInteractionDocumentation { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string ProbableMechanism { get; set; } = null!;

    [StringLength(5000)]
    [Unicode(false)]
    public string ActionsToBeTaken { get; set; } = null!;

    [StringLength(5000)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
