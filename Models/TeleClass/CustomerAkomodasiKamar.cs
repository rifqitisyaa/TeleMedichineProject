using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BusinessPartnerID", "ClassCode", "CustomerItemCode")]
public partial class CustomerAkomodasiKamar
{
    [Key]
    public int BusinessPartnerID { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string CustomerItemCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? CustomerItemName { get; set; }

    public int? ItemID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("CustomerAkomodasiKamar")]
    public virtual BusinessPartner BusinessPartner { get; set; } = null!;

    [ForeignKey("ClassCode")]
    [InverseProperty("CustomerAkomodasiKamar")]
    public virtual Class ClassCodeNavigation { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("CustomerAkomodasiKamar")]
    public virtual Item? Item { get; set; }
}
