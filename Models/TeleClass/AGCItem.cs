using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AGCItem
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string AGCItemCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string AGCItemName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("AGCItemCodeNavigation")]
    public virtual ICollection<AGCGroup> AGCGroup { get; set; } = new List<AGCGroup>();

    [InverseProperty("AGCItemCodeNavigation")]
    public virtual ICollection<TransactionCodeCOA> TransactionCodeCOA { get; set; } = new List<TransactionCodeCOA>();
}
