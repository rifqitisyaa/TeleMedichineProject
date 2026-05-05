using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ServiceUnitId", "SlipType")]
public partial class ServiceUnitPrinter
{
    [Key]
    public int ServiceUnitId { get; set; }

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string SlipType { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string PrinterPath { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ServiceUnitId")]
    [InverseProperty("ServiceUnitPrinter")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;
}
