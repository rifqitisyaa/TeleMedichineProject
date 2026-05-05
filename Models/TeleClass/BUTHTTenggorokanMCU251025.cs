using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class BUTHTTenggorokanMCU251025
{
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? FaringDextra { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? FaringSinistra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FaringKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TonsilDextra { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TonsilSinistra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TonsilKeterangan { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? UkuranTonsilDextra { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? UkuranTonsilSinistra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? UkTonsilKeterangan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    public string? FaringDextraKeterangan { get; set; }

    public string? FaringSinistraKeterangan { get; set; }

    public string? TonsilDextraKeterangan { get; set; }

    public string? TonsilSinistraKeterangan { get; set; }

    public string? UkuranTonsilDextraKeterangan { get; set; }

    public string? UkuranTonsilSinistraKeterangan { get; set; }
}
