using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BusinessPartnerID", "ClassCode")]
public partial class CustomerClass
{
    [Key]
    public int BusinessPartnerID { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CustomerClassCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string CustomerClassName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("CustomerClass")]
    public virtual BusinessPartner BusinessPartner { get; set; } = null!;

    [ForeignKey("ClassCode")]
    [InverseProperty("CustomerClass")]
    public virtual Class ClassCodeNavigation { get; set; } = null!;
}
