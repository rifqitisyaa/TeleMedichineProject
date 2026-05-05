using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class BpjsVerification
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string SepNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegistrationDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DischargeDateTime { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ParamedicName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? InacbgCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? InacbgName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VerificationDate { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? HospitalAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? BPJSAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? RillAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? ClaaimAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? ApprovedAmount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
