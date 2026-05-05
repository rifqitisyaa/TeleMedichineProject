using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class BUTHTHidungMCU251025
{
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? MukosaDextra { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MukosaSinistra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MukosaKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SeptumNasiDextra { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SeptumNasiSinistra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SeptumNasiKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KonkaNasalDextra { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KonkaNasalSinistra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KonkaNasalKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? EpistaksisDextra { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? EpistaksisSinistra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? EpistaksisKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SekretDextra { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SekretSinistra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SekretKeterangan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    public string? MukosaDextraKeterangan { get; set; }

    public string? MukosaSinistraKeterangan { get; set; }

    public string? SeptumNasiDextraKeterangan { get; set; }

    public string? SeptumNasiSinistraKeterangan { get; set; }

    public string? KonkaNasalDextraKeterangan { get; set; }

    public string? KonkaNasalSinistraKeterangan { get; set; }

    public string? EpistaksisDextraKeterangan { get; set; }

    public string? EpistaksisSinistraKeterangan { get; set; }

    public string? SekretDextraKeterangan { get; set; }

    public string? SekretSinistraKeterangan { get; set; }
}
