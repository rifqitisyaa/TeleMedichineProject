using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PanelOrdinalLaboratory
{
    [Key]
    public int ID { get; set; }

    public int? ItemID { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ResultValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SnomedCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? SnomedName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ReferenceRangeText { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
