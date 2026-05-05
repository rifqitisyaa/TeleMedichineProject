using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("DocumentNo", "ClassCode")]
public partial class CustomerContractClass
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string DocumentNo { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MinAdministrationCharge { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal MaxAdministrationCharge { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal PercentageAdministrationCharge { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("ClassCode")]
    [InverseProperty("CustomerContractClass")]
    public virtual Class ClassCodeNavigation { get; set; } = null!;

    [ForeignKey("DocumentNo")]
    [InverseProperty("CustomerContractClass")]
    public virtual CustomerContract DocumentNoNavigation { get; set; } = null!;
}
