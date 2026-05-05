using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SiteCode", "GCRL6Type", "RLReportID", "Period")]
public partial class RL6InfeksiNosokomial
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCRL6Type { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string RLReportID { get; set; } = null!;

    [Key]
    [StringLength(6)]
    [Unicode(false)]
    public string Period { get; set; } = null!;

    public int PasienKeluar { get; set; }

    public int IskIn { get; set; }

    public int IskPasienKateter { get; set; }

    public int IloIn { get; set; }

    public int IloPasienOperasi { get; set; }

    public int PneumoniaIn { get; set; }

    public int PneumoniaAllPatient { get; set; }

    public int SepsisIn { get; set; }

    public int SepsisAllPatient { get; set; }

    public int DekubitusiIn { get; set; }

    public int DekubitusiAllPatient { get; set; }

    public int PhlebitisIn { get; set; }

    public int PhlebitisAllPatient { get; set; }

    public int LainLainIn { get; set; }

    public int LainLainPasienBeresiko { get; set; }

    public bool IsProceed { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCRL6Type")]
    [InverseProperty("RL6InfeksiNosokomial")]
    public virtual sysGeneralCode GCRL6TypeNavigation { get; set; } = null!;

    [ForeignKey("GCRL6Type, RLReportID")]
    [InverseProperty("RL6InfeksiNosokomial")]
    public virtual RLReportTemplate RLReportTemplate { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("RL6InfeksiNosokomial")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
