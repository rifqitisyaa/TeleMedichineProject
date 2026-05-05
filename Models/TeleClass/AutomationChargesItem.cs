using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ServiceUnitId", "ItemId", "SequenceNo")]
public partial class AutomationChargesItem
{
    [Key]
    public int ServiceUnitId { get; set; }

    [Key]
    public int ItemId { get; set; }

    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [Column(TypeName = "numeric(10, 2)")]
    public decimal DispenseQty { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal ChargesQty { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("AutomationChargesItem")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("ServiceUnitId")]
    [InverseProperty("AutomationChargesItem")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;
}
