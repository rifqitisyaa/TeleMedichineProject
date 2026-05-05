using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo")]
public partial class PatientMCUCompileHd
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CompileDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCCompileType { get; set; } = null!;

    [Unicode(false)]
    public string? Comment { get; set; }

    public int ParamedicId { get; set; }

    [Unicode(false)]
    public string? Summary { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCCompileType")]
    [InverseProperty("PatientMCUCompileHd")]
    public virtual sysGeneralCode GCCompileTypeNavigation { get; set; } = null!;

    [ForeignKey("ParamedicId")]
    [InverseProperty("PatientMCUCompileHd")]
    public virtual Paramedic Paramedic { get; set; } = null!;

    [InverseProperty("PatientMCUCompileHd")]
    public virtual ICollection<PatientMCUCompileDt> PatientMCUCompileDt { get; set; } = new List<PatientMCUCompileDt>();

    [ForeignKey("RegistrationNo")]
    [InverseProperty("PatientMCUCompileHd")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
