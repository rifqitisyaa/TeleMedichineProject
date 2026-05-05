using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class THTTelingaMCU
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? DaunTelingaDextra { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DaunTelingaSinistra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DaunTelingaKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LiangTelingaDextra { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LiangTelingaSinistra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LiangTelingaKeterangan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SerumenDextra { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SerumenSinistra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SerumenKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RefleksCahayaDextra { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RefleksCahayaSinistra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RefleksCahayaKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MembraneTympaniDextra { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MembraneTympaniSinistra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MembraneTympaniKeterangan { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RinneDextra { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RinneSinistra { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RinneKeterangan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Weber { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? WeberKeterangan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Schwabach { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SchwabachKeterangan { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Audiometri { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AudiometriKeterangan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    public string? DaunTelingaDextraKeterangan { get; set; }

    public string? DaunTelingaSinistraKeterangan { get; set; }

    public string? LiangTelingaDextraKeterangan { get; set; }

    public string? LiangTelingaSinistraKeterangan { get; set; }

    public string? SerumenDextraKeterangan { get; set; }

    public string? SerumenSinistraKeterangan { get; set; }

    public string? RefleksCahayaDextraKeterangan { get; set; }

    public string? RefleksCahayaSinistraKeterangan { get; set; }

    public string? MembraneTympaniDextraKeterangan { get; set; }

    public string? MembraneTympaniSinistraKeterangan { get; set; }

    public string? RinneDextraKeterangan { get; set; }

    public string? RinneSinistraKeterangan { get; set; }

    public string? WeberDextraKeterangan { get; set; }

    public string? WeberSinistraKeterangan { get; set; }

    public string? SchwabachDextraKeterangan { get; set; }

    public string? SchwabachSinistraKeterangan { get; set; }

    public string? AudiometriDextraKeterangan { get; set; }

    public string? AudiometriSinistraKeterangan { get; set; }
}
