using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ReferralPatient
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ReferralNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    public DateOnly ReferralDate { get; set; }

    public bool? IsReferralFrom { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? OriginRegistrationNo { get; set; }

    public int? OriginParamedicID { get; set; }

    public int? OriginServiceUnitID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCReferralType { get; set; }

    public bool? RujukBalik { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferralHealthcare { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ReferralAddress { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferralName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReferralSpecialty { get; set; }

    public bool? IsRequiredReplay { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    public bool? IsProcess { get; set; }

    public bool? IsReviewed { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ReasonForReferral { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DiagnosticNotes { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ExaminationNotes { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NomorRujukan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalRujukan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KodePPK { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TujuanRujukan { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DiagnosaRujukan { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DiagnosaTambahan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCKecelakaanKerja { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCTipeFaskes { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCPenjaminLaKatLanTas { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCProvinsi { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCKabupaten { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCKecamatan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TglKejadianKecelakaan { get; set; }

    [Unicode(false)]
    public string? KeteranganKKL { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NoLaporanPolisi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NoSuratControl { get; set; }

    public bool? IsKatarak { get; set; }

    public bool? IsCOB { get; set; }

    public bool? IsSuplesi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SepSuplesi { get; set; }

    public bool? IsPoliExecutive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KodePoliRujukan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KodeDPJP { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCReferralType")]
    [InverseProperty("ReferralPatient")]
    public virtual sysGeneralCode? GCReferralTypeNavigation { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("ReferralPatient")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;

    [ForeignKey("OriginRegistrationNo")]
    [InverseProperty("ReferralPatient")]
    public virtual Registration? OriginRegistrationNoNavigation { get; set; }

    [InverseProperty("ReferralNoNavigation")]
    public virtual ICollection<Registration> Registration { get; set; } = new List<Registration>();

    [ForeignKey("SiteCode")]
    [InverseProperty("ReferralPatient")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("ReferralPatient")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
