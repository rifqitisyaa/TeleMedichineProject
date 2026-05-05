using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class PatientApgarRsse
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime AssessmentDateTime { get; set; }

    public int? ParamedicID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? FrekuensiJantung { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? UsahaPernafasan { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? TonusOtot { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ReaksiRefleks { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? WarnaKulit { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Score { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Kesimpulan { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
