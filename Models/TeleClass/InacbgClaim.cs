using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class InacbgClaim
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCStatus { get; set; } = null!;

    public bool IsUpgradeClass { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? UpgradeClassCode { get; set; }

    public int LosUpgradeClass { get; set; }

    public bool IsHasIcuTreatment { get; set; }

    public int LosIcu { get; set; }

    public int IcuVentilator { get; set; }

    public int AdlSubAcute { get; set; }

    public int AdlChronic { get; set; }

    public bool? IsHasCOB { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? COBCode { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? BirthWeight { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? HospitalFare { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? GrouperFare { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? AdditionalFare { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? TotalAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? StatusCovid { get; set; }

    public bool? KomorbitKomplikasi { get; set; }

    public bool? RSDaruratLapangan { get; set; }

    public bool? CoInsiden { get; set; }

    public int? IcuDenganVen { get; set; }

    public int? IcuTanpaVen { get; set; }

    public int? IsoTekDenganVen { get; set; }

    public int? IsoTekTanpaVen { get; set; }

    public int? IsoNonDenganVen { get; set; }

    public int? IsoNonTanpaVen { get; set; }

    public int? TotalHari { get; set; }

    public int? TotalHariDijamin { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Penjamin { get; set; }

    public bool? IsPemulasaranJenazah { get; set; }

    public bool? IsKantongJenazah { get; set; }

    public bool? IsPetiJenazah { get; set; }

    public bool? IsPlastikErat { get; set; }

    public bool? IsDesinfektanJenazah { get; set; }

    public bool? IsTransportMobil { get; set; }

    public bool? IsDesinfektanMobil { get; set; }

    public bool? IsSentClaim { get; set; }

    public bool IsReviewed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ClaimNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SEPNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KartuIdentitasPasien { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NoIdentitasPasien { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CaraPulang { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCStatus")]
    [InverseProperty("InacbgClaim")]
    public virtual sysGeneralCode GCStatusNavigation { get; set; } = null!;

    [InverseProperty("InacbgClaim")]
    public virtual ICollection<InacbgGrouper> InacbgGrouper { get; set; } = new List<InacbgGrouper>();

    [ForeignKey("RegistrationNo")]
    [InverseProperty("InacbgClaim")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("UpgradeClassCode")]
    [InverseProperty("InacbgClaim")]
    public virtual Class? UpgradeClassCodeNavigation { get; set; }
}
