using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class RealizationFood
{
    public int RealizationId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RealizationDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal BudgetAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal RealizationAmount { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public int TotalPatient { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
