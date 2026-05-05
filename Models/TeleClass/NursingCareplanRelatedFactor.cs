using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NursingCareplanRelatedFactor
{
    [Key]
    public long NursingCareplanRelatedFactorID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string NursingCareplanNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string NandaRelatedFactorCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("NandaRelatedFactorCode")]
    [InverseProperty("NursingCareplanRelatedFactor")]
    public virtual NandaRelatedFactor NandaRelatedFactorCodeNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo, NursingCareplanNo")]
    [InverseProperty("NursingCareplanRelatedFactor")]
    public virtual NursingCareplan NursingCareplan { get; set; } = null!;
}
