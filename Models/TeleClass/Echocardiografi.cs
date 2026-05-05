using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "JobOrderNo")]
public partial class Echocardiografi
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string? SequenceNo { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? ItemName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ResultDate { get; set; }

    public int? AutorizedById { get; set; }

    public int? AssetsID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CPOENotes { get; set; }

    [Unicode(false)]
    public string? Diagnostik_Klinik { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Aoarta_RD { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ArtriumKiri_Dimension { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ArtriumKiri_LARation { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? VentrikelKanan_Dimension { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? FungsiJantung_EF { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? FungsiJantung_IVS { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? FungsiJantung_EPSS { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? FungsiJantung_MVA { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? VentrikelKiri_EDD { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ESD { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? IVS_Diastole { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? IVS_Systole { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? IVS_FracT { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PW_Diastole { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PW_Systole { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PW_FracT { get; set; }

    [Unicode(false)]
    public string? Triscupid_Valve { get; set; }

    [Unicode(false)]
    public string? Pulmonal_Valve { get; set; }

    [Unicode(false)]
    public string? Aorta_Valve { get; set; }

    [Unicode(false)]
    public string? Mitral_Valve { get; set; }

    [Unicode(false)]
    public string? Other { get; set; }

    [Unicode(false)]
    public string? PenemuanOrKomentar { get; set; }

    [Unicode(false)]
    public string? Kesimpulan { get; set; }

    [Column(TypeName = "image")]
    public byte[]? HasilEcho { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
