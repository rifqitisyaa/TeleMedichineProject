using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SatuSehatParamedic
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string PractitionerIHSNo { get; set; } = null!;

    public int? ParamedicID { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string ParamedicName { get; set; } = null!;

    public DateOnly? DateOfBirth { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCSex { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SSN { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
