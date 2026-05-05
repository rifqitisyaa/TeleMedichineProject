using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SuratKeteranganPenerbangan
{
    [Key]
    [StringLength(300)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? PhysicianName { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PhysicianPhone { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NurseName { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NursePhone { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatientBirthOfDate { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientAge { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientTravelPasport { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientTravelDestination { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatientTravelStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatientTravelEndDate { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientIllness { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientMedicine { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? SignaturePhysicianName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HeaderDateTime { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? LastUpdateDateTime { get; set; }

    public int LetterId { get; set; }
}
