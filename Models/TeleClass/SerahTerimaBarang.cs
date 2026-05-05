using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SerahTerimaBarang
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaBarangPenyerahan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaBarangPenyerahan1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaBarangPenyerahan2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JumlahBarangPenyerahan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JumlahBarangPenyerahan1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JumlahBarangPenyerahan2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KondisiBarangPenyerahan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KondisiBarangPenyerahan1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KondisiBarangPenyerahan2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaBarangPengembalian { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaBarangPengembalian1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaBarangPengembalian2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JumlahBarangPengembalian { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JumlahBarangPengembalian1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JumlahBarangPengembalian2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KondisiBarangPengembalian { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KondisiBarangPengembalian1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KondisiBarangPengembalian2 { get; set; }

    public bool? ChkPengembalian1 { get; set; }

    public bool? ChkPengembalian2 { get; set; }

    public bool? ChkPengembalian3 { get; set; }

    public bool? ChkPenyerahan1 { get; set; }

    public bool? ChkPenyerahan2 { get; set; }

    public bool? ChkPenyerahan3 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TglPenyerahan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TglPengembalian { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? JamPenyerahan { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? JamPengembalian { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateTime { get; set; }

    [ForeignKey("RegistrationNo")]
    [InverseProperty("SerahTerimaBarang")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
