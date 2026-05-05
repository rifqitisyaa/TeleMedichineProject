using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class DTD
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string DTDNo { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string DTDName { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string DTDLabel { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("DTDNoNavigation")]
    public virtual ICollection<Diagnosis> Diagnosis { get; set; } = new List<Diagnosis>();

    [InverseProperty("DTDNoNavigation")]
    public virtual ICollection<DiagnosisTB> DiagnosisTB { get; set; } = new List<DiagnosisTB>();

    [InverseProperty("DTDNoNavigation")]
    public virtual ICollection<RL2Morbiditas> RL2Morbiditas { get; set; } = new List<RL2Morbiditas>();
}
