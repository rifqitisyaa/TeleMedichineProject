using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("GCRLType", "RLReportID")]
public partial class RLReportTemplate
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCRLType { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string RLReportID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string RLReportName { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? RelatedField { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCUnit { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCRLType")]
    [InverseProperty("RLReportTemplate")]
    public virtual sysGeneralCode GCRLTypeNavigation { get; set; } = null!;

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1BayiTabung> RL1BayiTabung { get; set; } = new List<RL1BayiTabung>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1CaraPembayaran> RL1CaraPembayaran { get; set; } = new List<RL1CaraPembayaran>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1KebidananPerinatologi> RL1KebidananPerinatologi { get; set; } = new List<RL1KebidananPerinatologi>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1KegiatanFarmasi> RL1KegiatanFarmasi { get; set; } = new List<RL1KegiatanFarmasi>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1KegiatanPelayananKhusus> RL1KegiatanPelayananKhusus { get; set; } = new List<RL1KegiatanPelayananKhusus>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1KegiatanRadiologi> RL1KegiatanRadiologi { get; set; } = new List<RL1KegiatanRadiologi>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1KegiatanRujukan> RL1KegiatanRujukan { get; set; } = new List<RL1KegiatanRujukan>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1KeluargaBerencana> RL1KeluargaBerencana { get; set; } = new List<RL1KeluargaBerencana>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1KesehatanGigiMulut> RL1KesehatanGigiMulut { get; set; } = new List<RL1KesehatanGigiMulut>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1KesehatanJiwa> RL1KesehatanJiwa { get; set; } = new List<RL1KesehatanJiwa>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1KunjunganRJ> RL1KunjunganRJ { get; set; } = new List<RL1KunjunganRJ>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1KunjunganRumah> RL1KunjunganRumah { get; set; } = new List<RL1KunjunganRumah>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1PelayananRI> RL1PelayananRI { get; set; } = new List<RL1PelayananRI>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1PemantauanDokter> RL1PemantauanDokter { get; set; } = new List<RL1PemantauanDokter>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1Pembedahan> RL1Pembedahan { get; set; } = new List<RL1Pembedahan>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1PembedahanMata> RL1PembedahanMata { get; set; } = new List<RL1PembedahanMata>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1PemeriksaanLaboratorium> RL1PemeriksaanLaboratorium { get; set; } = new List<RL1PemeriksaanLaboratorium>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1Pengunjung> RL1Pengunjung { get; set; } = new List<RL1Pengunjung>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1PenyalahgunaanNAPZA> RL1PenyalahgunaanNAPZA { get; set; } = new List<RL1PenyalahgunaanNAPZA>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1PenyuluhanKesehatan> RL1PenyuluhanKesehatan { get; set; } = new List<RL1PenyuluhanKesehatan>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1RehabilitasiMedik> RL1RehabilitasiMedik { get; set; } = new List<RL1RehabilitasiMedik>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1Training> RL1Training { get; set; } = new List<RL1Training>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL1TranfusiDarah> RL1TranfusiDarah { get; set; } = new List<RL1TranfusiDarah>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL3DataDasarRumahSakit> RL3DataDasarRumahSakit { get; set; } = new List<RL3DataDasarRumahSakit>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL4DataKetenagaan> RL4DataKetenagaan { get; set; } = new List<RL4DataKetenagaan>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL5DataPeralatanMedik> RL5DataPeralatanMedik { get; set; } = new List<RL5DataPeralatanMedik>();

    [InverseProperty("RLReportTemplate")]
    public virtual ICollection<RL6InfeksiNosokomial> RL6InfeksiNosokomial { get; set; } = new List<RL6InfeksiNosokomial>();
}
