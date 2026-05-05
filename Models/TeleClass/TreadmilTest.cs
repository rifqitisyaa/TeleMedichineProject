using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class TreadmilTest
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TreadmilDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ParamedicName { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? EcgIrama { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? EcgAxis { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? EcgPRInterval { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? EcgStSegment { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? EcgTwave { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? TestProtocol { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? TestDenyutJantungMax { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? TestTarget { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? EndTestMunites { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? EndTestReason { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? EndTestRest { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? EndTestMax { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? TestResponsTekananDarah { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? TestAritmia { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? TestNyeriDada { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? TestGejalaLain { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PerubahanUjiLatih { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PerubahanLead { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PerubahanMenitKe { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PerubahanNormalisasi { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? FunctionalClass { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? KapasitasErobik { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? TingkatKesegaran { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HasilTest { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? CatatanLain { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Anjuran { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Signature { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
