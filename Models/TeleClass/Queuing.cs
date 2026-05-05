using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("ReferenceNo", Name = "IXReferenNo_Queuing")]
public partial class Queuing
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime QueueDatetime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string IpAddress { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ReferenceNo { get; set; } = null!;

    public int? ParamedicId { get; set; }

    public int? ServiceUnitId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string QueueNo { get; set; } = null!;

    [Column(TypeName = "decimal(10, 2)")]
    public decimal SequenceNo { get; set; }

    public int CallNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WorkShiftCode { get; set; }

    public bool? IsDisplay { get; set; }

    public bool IsAttend { get; set; }

    public bool IsFromRegistration { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ParamedicId")]
    [InverseProperty("Queuing")]
    public virtual Paramedic? Paramedic { get; set; }

    [ForeignKey("ServiceUnitId")]
    [InverseProperty("Queuing")]
    public virtual DepartmentServiceUnit? ServiceUnit { get; set; }
}
