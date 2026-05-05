using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RoomID", "ServiceUnitID")]
public partial class SatuSehatServiceUnitRoom
{
    [Key]
    public int RoomID { get; set; }

    [Key]
    public int ServiceUnitID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SatuSehatID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
