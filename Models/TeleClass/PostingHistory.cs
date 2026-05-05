using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PostingHistory
{
    [Key]
    public int ID { get; set; }

    public DateOnly DateFrom { get; set; }

    public DateOnly DateTo { get; set; }

    public int CountRecord { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartPostingDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndPostingDateTime { get; set; }

    public int Duration { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string PostedBy { get; set; } = null!;
}
