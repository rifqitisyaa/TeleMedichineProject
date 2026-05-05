using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Nic
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string NicCode { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? NicDescription { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string NicDefinition { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string NicClassCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("NicCodeNavigation")]
    public virtual ICollection<NandaNicAdditional> NandaNicAdditional { get; set; } = new List<NandaNicAdditional>();

    [InverseProperty("NicCodeNavigation")]
    public virtual ICollection<NandaNicPriority> NandaNicPriority { get; set; } = new List<NandaNicPriority>();

    [InverseProperty("NicCodeNavigation")]
    public virtual ICollection<NandaNicSuggested> NandaNicSuggested { get; set; } = new List<NandaNicSuggested>();

    [InverseProperty("NicCodeNavigation")]
    public virtual ICollection<NicActivity> NicActivity { get; set; } = new List<NicActivity>();

    [ForeignKey("NicClassCode")]
    [InverseProperty("Nic")]
    public virtual NicClass NicClassCodeNavigation { get; set; } = null!;

    [InverseProperty("NicCodeNavigation")]
    public virtual ICollection<NursingCareplanIntervention> NursingCareplanIntervention { get; set; } = new List<NursingCareplanIntervention>();
}
