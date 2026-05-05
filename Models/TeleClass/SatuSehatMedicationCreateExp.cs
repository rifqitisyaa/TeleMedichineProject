using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SatuSehatMedicationCreateExp
{
    [Key]
    public int ItemID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MedicationCreateID { get; set; }

    public DateOnly? BatchExpirationDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BatchLotNumber { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ItemName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Status { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
