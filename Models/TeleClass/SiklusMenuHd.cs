using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SiklusMenuHd
{
    [Key]
    public int SiklusId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string SiklusName { get; set; } = null!;

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDatetime { get; set; }

    [InverseProperty("Siklus")]
    public virtual ICollection<SiklusMenuDt> SiklusMenuDt { get; set; } = new List<SiklusMenuDt>();
}
