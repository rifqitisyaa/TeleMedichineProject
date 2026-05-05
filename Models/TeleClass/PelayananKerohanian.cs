using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PelayananKerohanian
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaPasien { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NoRekamMedis { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TglDanJamLahir { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaKeluarga { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HubunganDenganPasien { get; set; }

    public bool? chkKunjungan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tglKunjungan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNKunjungan1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNKunjungan2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNKunjungan3 { get; set; }

    public bool? chkKunjunganDoa { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tglKunjunganDoa { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNKunjunganDoa1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNKunjunganDoa2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNKunjunganDoa3 { get; set; }

    public bool? chkPendampingKeluarga { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tglPendampingKeluarga { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNPendampingKeluarga1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNPendampingKeluarga2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNPendampingKeluarga3 { get; set; }

    public bool? chkPendampingHidup { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tglPendampingHidup { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNPendampingHidup1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNPendampingHidup2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNPendampingHidup3 { get; set; }

    public bool? chkPengakuanDosa { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tglPengakuanDosa { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNPengakuanDosa1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNPengakuanDosa2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNPengakuanDosa3 { get; set; }

    public bool? chkSakramen { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tglSakramen { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNSakramen1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNSakramen2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNSakramen3 { get; set; }

    public bool? chkKudus { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tglKudus { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNKudus1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNKudus2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNKudus3 { get; set; }

    public bool? chkBaptis { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tglBaptis { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNBaptis1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNBaptis2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNBaptis3 { get; set; }

    public bool? chkJenazah { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tglJenazah { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNJenazah1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNJenazah2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNJenazah3 { get; set; }

    public bool? chkLain { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tglLain { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNLain1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNLain2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WPNLain3 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PasienWali { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Kerohanian { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Perawat { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PelayananKerohanian")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
