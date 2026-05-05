using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "Period", "MedicalNo")]
public partial class RL2Imunisasi
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    [StringLength(6)]
    [Unicode(false)]
    public string Period { get; set; } = null!;

    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Sex { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Umur { get; set; } = null!;

    public bool Dipteri { get; set; }

    public bool Pertusis { get; set; }

    public bool Tetanus { get; set; }

    public bool TetanusNeoNatrum { get; set; }

    public bool TBCParu { get; set; }

    public bool Campak { get; set; }

    public bool Polio { get; set; }

    public bool Hepatitis { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string StatusImunisasi { get; set; } = null!;

    public bool IsAlive { get; set; }

    public bool IsProceed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("MedicalNo")]
    [InverseProperty("RL2Imunisasi")]
    public virtual Patient MedicalNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("RL2Imunisasi")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
