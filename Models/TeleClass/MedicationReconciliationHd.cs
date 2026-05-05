using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenNo")]
public partial class MedicationReconciliationHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SequenNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string MedicationName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Dosage { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ConsumMethode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Route { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreateDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StopDateTime { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
