using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BusinessPartnerID", "ItemID")]
public partial class SupplierItem
{
    [Key]
    public int BusinessPartnerID { get; set; }

    [Key]
    public int ItemID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string SupplierItemCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? SupplierItemName { get; set; }

    public byte LeadTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BusinessPartnerID")]
    [InverseProperty("SupplierItem")]
    public virtual BusinessPartner BusinessPartner { get; set; } = null!;

    [ForeignKey("ItemID")]
    [InverseProperty("SupplierItem")]
    public virtual Item Item { get; set; } = null!;
}
