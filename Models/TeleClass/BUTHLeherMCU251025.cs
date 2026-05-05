using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class BUTHLeherMCU251025
{
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? KGBDextra { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KGBSinistra { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? KeteranganLeher { get; set; }

    [Column(TypeName = "image")]
    public byte[]? TTD { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ParamedicName { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Kesimpulan { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Saran { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    public string? KGBDextraKeterangan { get; set; }

    public string? KGBSinistraKeterangan { get; set; }
}
