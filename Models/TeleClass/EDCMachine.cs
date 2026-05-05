using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class EDCMachine
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string EDCMachineCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string EDCMachineName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCCardProvider { get; set; } = null!;

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Charges { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("EDCMachineCodeNavigation")]
    public virtual ICollection<AccountReceivablePaymentDt> AccountReceivablePaymentDt { get; set; } = new List<AccountReceivablePaymentDt>();
}
