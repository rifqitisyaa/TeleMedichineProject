using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("Id", "Period")]
public partial class PayrollPeriodDt
{
    [Key]
    public int Id { get; set; }

    [Key]
    public int Period { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string Year { get; set; } = null!;

    [StringLength(6)]
    [Unicode(false)]
    public string PayrollPeriod { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Label { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDatetime { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("PayrollPeriodDt")]
    public virtual PayrollPeriodHd IdNavigation { get; set; } = null!;
}
