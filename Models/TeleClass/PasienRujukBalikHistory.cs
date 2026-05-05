using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PasienRujukBalikHistory
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PotensiPRBDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PRBDate { get; set; }

    public int? ParamedicID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DiagnosisCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Reason { get; set; }

    public bool? IsPotensiPRB { get; set; }

    public bool? IsPRB { get; set; }

    public bool? IsSelesaiPRB { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
