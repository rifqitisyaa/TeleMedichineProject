using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BusinessPartnerID", "ServiceUnitCode")]
public partial class CustomerServiceUnit
{
    [Key]
    public int BusinessPartnerID { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ServiceUnitCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CustomerServiceUnitCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CustomerServiceUnitName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("CustomerServiceUnit")]
    public virtual BusinessPartner BusinessPartner { get; set; } = null!;

    [ForeignKey("ServiceUnitCode")]
    [InverseProperty("CustomerServiceUnit")]
    public virtual ServiceUnit ServiceUnitCodeNavigation { get; set; } = null!;
}
