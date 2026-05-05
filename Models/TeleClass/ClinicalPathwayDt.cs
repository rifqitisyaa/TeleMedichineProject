using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "SequenceNo", "ItemId")]
public partial class ClinicalPathwayDt
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
    public int ItemId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ReferenceNo { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string ReferenceSequenceNo { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("RegistrationNo, SequenceNo")]
    [InverseProperty("ClinicalPathwayDt")]
    public virtual ClinicalPathwayHd ClinicalPathwayHd { get; set; } = null!;

    [ForeignKey("ItemId")]
    [InverseProperty("ClinicalPathwayDt")]
    public virtual Item Item { get; set; } = null!;
}
