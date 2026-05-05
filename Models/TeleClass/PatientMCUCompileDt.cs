using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo", "ItemCompileCode")]
public partial class PatientMCUCompileDt
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ItemCompileCode { get; set; } = null!;

    [Unicode(false)]
    public string? CompileAdditionalName { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo, SequenceNo")]
    [InverseProperty("PatientMCUCompileDt")]
    public virtual PatientMCUCompileHd PatientMCUCompileHd { get; set; } = null!;
}
