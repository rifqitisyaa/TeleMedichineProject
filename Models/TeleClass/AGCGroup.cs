using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("AGCGroup1", "GCAGCGroupType", "GCAGCType", "AGCItemCode", "SequenceNo")]
public partial class AGCGroup
{
    [Key]
    [Column("AGCGroup")]
    [StringLength(50)]
    [Unicode(false)]
    public string AGCGroup1 { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCAGCGroupType { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GCAGCType { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string AGCItemCode { get; set; } = null!;

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? COACode { get; set; }

    public bool IsAlreadySet { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("AGCItemCode")]
    [InverseProperty("AGCGroup")]
    public virtual AGCItem AGCItemCodeNavigation { get; set; } = null!;

    [ForeignKey("COACode")]
    [InverseProperty("AGCGroup")]
    public virtual ChartOfAccount? COACodeNavigation { get; set; }

    [ForeignKey("GCAGCGroupType")]
    [InverseProperty("AGCGroup")]
    public virtual sysGeneralCode GCAGCGroupTypeNavigation { get; set; } = null!;
}
