using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("DomainCode", "RegistrationNo")]
public partial class IDNTChecklist
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string DomainCode { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Unicode(false)]
    public string? ValueData { get; set; }

    public bool? ChecklistSymptom001 { get; set; }

    public bool? ChecklistSymptom002 { get; set; }

    public bool? ChecklistSymptom003 { get; set; }

    public bool? ChecklistSymptom004 { get; set; }

    public bool? ChecklistSymptom005 { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
