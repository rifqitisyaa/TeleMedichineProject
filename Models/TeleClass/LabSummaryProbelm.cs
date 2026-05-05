using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "JoborderNo", "SequenceNo")]
public partial class LabSummaryProbelm
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string JoborderNo { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? CholesterolHasil { get; set; }

    [Unicode(false)]
    public string? FungsiHati { get; set; }

    [Unicode(false)]
    public string? FungsiGinjal { get; set; }

    [Unicode(false)]
    public string? DiabetesMelitius { get; set; }

    [Unicode(false)]
    public string? DarahRutin { get; set; }

    [Unicode(false)]
    public string? AsamUrat { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDatetime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }
}
