using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "NursingCareplanNo", "NursingCareplanInterventionNo")]
public partial class NursingCareplanIntervention
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string NursingCareplanNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string NursingCareplanInterventionNo { get; set; } = null!;

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
    [InverseProperty("NursingCareplanIntervention")]
    public virtual Nic NicCodeNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo, NursingCareplanNo")]
    [InverseProperty("NursingCareplanIntervention")]
    public virtual NursingCareplan NursingCareplan { get; set; } = null!;

    [InverseProperty("NursingCareplanIntervention")]
    public virtual ICollection<NursingCareplanInterventionActivity> NursingCareplanInterventionActivity { get; set; } = new List<NursingCareplanInterventionActivity>();
}
