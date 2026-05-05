using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("MedicalNo", "SequenceNo")]
public partial class ResikoJatuh
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? AssesmentDateTime { get; set; }

    public int? ParamedicID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? UmurValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DefisitSensorisValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AktivitasValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RiwayatJatuhValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KognisiValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AlatKesehatanValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MobilitasValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PolaBabBakValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KomorbiditasValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NamaPetugas { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TanggalResikoJatuh { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RisikoJatuhValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ResikoKategori { get; set; }
}
