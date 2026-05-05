using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class AnalisaHasilMCU
{
    [StringLength(30)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? umur { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? jk { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? dept { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? posisi { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? merokok { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? alkohol { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? olahraga { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? rki { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? rkk { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? rv { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? bmiNw { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? bmiUw { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? bmiOw { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? bmiO { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? lpOs { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? pMln { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? pMlt { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? pMlst { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? pMon { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? pMor { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? tdHiper { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? mata { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? tht { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ohisBuruk { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ohisSedang { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ohisBaik { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? gigiAb { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? gigiDecay { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? gigiMissing { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? gigiFilling { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? gigiNormal { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? dadaNormal { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? dadaAbnor { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? perutNormal { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? perutAbnor { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? extremitasNormal { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? extremitasAbnor { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? labAnemia { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? labPreDm { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? labDm { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? labHiperurisemia { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? labDislipid { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? labLain { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? thoraxParu { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? thoraxJantung { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ekg { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? treadmil { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? papsmear { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ketaksaan1 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ketaksaan2 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ketaksaan3 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? konflik1 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? konflik2 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? konflik3 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? bbKuantitatif1 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? bbKuantitatif2 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? bbKuantitatif3 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? bbKualitatif1 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? bbKualitatif2 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? bbKualitatif3 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? pengembangKarir1 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? pengembangKarir2 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? pengembangKarir3 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? tanggungPersonal1 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? tanggungPersonal2 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? tanggungPersonal3 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? srq20TdkAda { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? srq20Ada { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? RisikoPkvaLab { get; set; }
}
