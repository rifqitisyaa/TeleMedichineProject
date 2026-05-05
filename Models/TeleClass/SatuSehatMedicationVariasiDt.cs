using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicationCreateID", "IngredientCode", "NumeratorValue", "NumeratorCode", "DenominatorValue", "DenominatorCode")]
public partial class SatuSehatMedicationVariasiDt
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string MedicationCreateID { get; set; } = null!;

    public int? Position { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string IngredientCode { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? IngredientDisplay { get; set; }

    [Key]
    [Column(TypeName = "numeric(18, 4)")]
    public decimal NumeratorValue { get; set; }

    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string NumeratorCode { get; set; } = null!;

    [Key]
    [Column(TypeName = "numeric(18, 4)")]
    public decimal DenominatorValue { get; set; }

    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string DenominatorCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("MedicationCreateID")]
    [InverseProperty("SatuSehatMedicationVariasiDt")]
    public virtual SatuSehatMedicationVariasiHd MedicationCreate { get; set; } = null!;
}
