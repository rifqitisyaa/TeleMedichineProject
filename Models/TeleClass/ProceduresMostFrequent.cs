using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("L1", "L2", "L3", "ProcedureCode")]
public partial class ProceduresMostFrequent
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string L1 { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string L2 { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string L3 { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ProcedureCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDate { get; set; }

    [ForeignKey("ProcedureCode")]
    [InverseProperty("ProceduresMostFrequent")]
    public virtual Procedures ProcedureCodeNavigation { get; set; } = null!;
}
