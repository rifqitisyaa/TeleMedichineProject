using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BusinessPartnerID", "ItemID", "Type")]
public partial class CustomerItem
{
    [Key]
    public int BusinessPartnerID { get; set; }

    [Key]
    public int ItemID { get; set; }

    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CustomerItemCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string CustomerItemName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("CustomerItem")]
    public virtual BusinessPartner BusinessPartner { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("CustomerItem")]
    public virtual Item Item { get; set; } = null!;
}
