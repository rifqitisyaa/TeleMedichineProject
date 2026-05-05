using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DrugInfoHd
{
    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int LastImportId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDateTime { get; set; }

    [InverseProperty("SequenceNoNavigation")]
    public virtual ICollection<DrugInfoDt> DrugInfoDt { get; set; } = new List<DrugInfoDt>();
}
