using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class PemeriksaanInfeksiHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int? RoomId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCPemakaianAlatMedis { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? TglMulai { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TglSelesai { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TglDitemukanGejala { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCPosisiPasang { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string UkuranSelang { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string JenisSelang { get; set; } = null!;

    [Unicode(false)]
    public string Keterangan { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }

    [ForeignKey("GCPemakaianAlatMedis")]
    [InverseProperty("PemeriksaanInfeksiHdGCPemakaianAlatMedisNavigation")]
    public virtual sysGeneralCode GCPemakaianAlatMedisNavigation { get; set; } = null!;

    [ForeignKey("GCPosisiPasang")]
    [InverseProperty("PemeriksaanInfeksiHdGCPosisiPasangNavigation")]
    public virtual sysGeneralCode GCPosisiPasangNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PemeriksaanInfeksiHd")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
