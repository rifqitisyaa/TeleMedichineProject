using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "EligibilitasNo", "BusinessPartnerId")]
public partial class PatientCorporateEligibility
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string EligibilitasNo { get; set; } = null!;

    [Key]
    public int BusinessPartnerId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CardNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? EligibilitasDateTime { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? IdAkomodasi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ClaimNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PlanPasien { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KodePerusahaan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaPerusahaanPenjamin { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferenceCorporate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Produk { get; set; }

    [Unicode(false)]
    public string? Benefit { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SpecialtyCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DiagnosaCode { get; set; }

    [Unicode(false)]
    public string? DiagnosaName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaKeluargaPenjamin { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Kelas { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TujuanKunj { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Pembiayaan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FlagProcedure { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KdPenunjang { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AssesmentPel { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? BpjsDpjp { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? noLP { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessPartnerId")]
    [InverseProperty("PatientCorporateEligibility")]
    public virtual BusinessPartner BusinessPartner { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PatientCorporateEligibility")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
