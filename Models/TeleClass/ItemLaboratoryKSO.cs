using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("GeneralCodeId", "ItemID")]
public partial class ItemLaboratoryKSO
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GeneralCodeId { get; set; } = null!;

    [Key]
    public int ItemID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
