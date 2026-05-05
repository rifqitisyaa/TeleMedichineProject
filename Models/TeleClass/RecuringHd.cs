using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class RecuringHd
{
    [Key]
    public int RecuringID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public int StartMonth { get; set; }

    public int StartYear { get; set; }

    public int EndMonth { get; set; }

    public int EndYear { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal TotalAmount { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Recuring")]
    public virtual ICollection<RecuringDt> RecuringDt { get; set; } = new List<RecuringDt>();

    [InverseProperty("Recuring")]
    public virtual ICollection<RecuringSubDt> RecuringSubDt { get; set; } = new List<RecuringSubDt>();
}
