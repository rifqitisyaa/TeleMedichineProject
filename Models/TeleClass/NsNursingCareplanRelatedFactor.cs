using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("DetailId", "NursingCareplanRelatedFactorID")]
public partial class NsNursingCareplanRelatedFactor
{
    [Key]
    public long DetailId { get; set; }

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

    [ForeignKey("DetailId")]
    [InverseProperty("NsNursingCareplanRelatedFactor")]
    public virtual NurseShiftTransferHistoryDt Detail { get; set; } = null!;
}
