using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class RecalculationItemInventoryHd
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RecalculationDateTime { get; set; }

    [Unicode(false)]
    public string Reason { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
