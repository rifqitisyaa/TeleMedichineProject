using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ReviewPharOrder
{
    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ReviewedOrderDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReviewedBy { get; set; }
}
