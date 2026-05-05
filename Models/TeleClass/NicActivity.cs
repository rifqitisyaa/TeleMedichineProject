using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NicActivity
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string NicActivityCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string NicActivityName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string NicCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("NicCode")]
    [InverseProperty("NicActivity")]
    public virtual Nic NicCodeNavigation { get; set; } = null!;

    [InverseProperty("NicActivityCodeNavigation")]
    public virtual ICollection<NursingCareplanInterventionActivity> NursingCareplanInterventionActivity { get; set; } = new List<NursingCareplanInterventionActivity>();
}
