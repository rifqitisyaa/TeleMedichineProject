using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class Partograf
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PartografDateTime { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? PartografTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DenyutJantung { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AirKetuban { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Penyusupan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Pembukaan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TurunnyaKepala { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Kontraksi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Oksitosin { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TekananDarahSistolik { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TekananDarahDiastolik { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Suhu { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Urin { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Minum { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UrinProtein { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UrinAseton { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UrinVolume { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nadi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Kontraksi20 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Kontraksi2040 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Kontraksi40 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Tetesan { get; set; }

    [Unicode(false)]
    public string? ObatdanCairanIV { get; set; }

    [Unicode(false)]
    public string? DIIT { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
