using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class DietNutrientHistory
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PreparedDateTime { get; set; }

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? ServiceUnitID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BedID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ChargeClassCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GCPatientStatus { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GCFoodTexture { get; set; }

    [Unicode(false)]
    public string? DietType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DietCalories { get; set; }

    [Unicode(false)]
    public string? Prohibition { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Weight { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Height { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool? IsFasting { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
