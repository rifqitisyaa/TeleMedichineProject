using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NursingCareplanRiskFactor
{
    [Key]
    public long NursingCareplanRiskFactorID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string NursingCareplanNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string NandaRiskFactorCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("NandaRiskFactorCode")]
    [InverseProperty("NursingCareplanRiskFactor")]
    public virtual NandaRiskFactor NandaRiskFactorCodeNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo, NursingCareplanNo")]
    [InverseProperty("NursingCareplanRiskFactor")]
    public virtual NursingCareplan NursingCareplan { get; set; } = null!;
}
