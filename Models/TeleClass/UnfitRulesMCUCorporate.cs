using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ProjectMCUNo", "SequenceNo")]
public partial class UnfitRulesMCUCorporate
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ProjectMCUNo { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string DepartmentName { get; set; } = null!;

    public int RulesID { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RulesID")]
    [InverseProperty("UnfitRulesMCUCorporate")]
    public virtual RulesMCUHd Rules { get; set; } = null!;
}
