using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("BusinessPartnerID", "ItemID")]
public partial class CustomerItemPRB
{
    [Key]
    public int BusinessPartnerID { get; set; }

    [Key]
    public int ItemID { get; set; }

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
}
