using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class LocationEngineering
{
    [Key]
    public int LocationID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string LocationName { get; set; } = null!;

    public double? LocationScale { get; set; }

    public int? LocationFloor { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Location")]
    public virtual ICollection<Engineering> Engineering { get; set; } = new List<Engineering>();
}
