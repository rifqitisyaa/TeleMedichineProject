using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class NutritionConsultation
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int NutritionistID { get; set; }

    public DateOnly ConsultationDate { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string ConsultationTime { get; set; } = null!;

    public int DPJP { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? Weight { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? Height { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal? BloodPressure { get; set; }

    [Unicode(false)]
    public string? CheckUpResult { get; set; }

    [Unicode(false)]
    public string? MedicalDiagnosis { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? GCDietType { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
