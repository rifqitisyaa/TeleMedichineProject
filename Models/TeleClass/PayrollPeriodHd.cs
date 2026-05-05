using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PayrollPeriodHd
{
    [Key]
    public int Id { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string Year { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCPeriodType { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCPeriodType")]
    [InverseProperty("PayrollPeriodHd")]
    public virtual sysGeneralCode GCPeriodTypeNavigation { get; set; } = null!;

    [InverseProperty("IdNavigation")]
    public virtual ICollection<PayrollPeriodDt> PayrollPeriodDt { get; set; } = new List<PayrollPeriodDt>();
}
