using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class AntibiotikProfilaksis
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? SequenceOp { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NamaAntibiotik { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WaktuPemberian { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CaraPemberian { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Dosis { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StatusPemberian { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JenisTerapi { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? DurasiPemakaian { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
