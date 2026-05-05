using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SurgeryCategory
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string CategoryCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string CategoryName { get; set; } = null!;

    public int Duration { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("CategoryCodeNavigation")]
    public virtual ICollection<SurgeryReservation> SurgeryReservation { get; set; } = new List<SurgeryReservation>();
}
