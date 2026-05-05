using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class NurseShiftTransferHistoryHd
{
    [Key]
    public long TransferId { get; set; }

    public int ServiceUnitId { get; set; }

    public int FromNurseId { get; set; }

    public int ToNurseId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TransferDateTime { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("FromNurseId")]
    [InverseProperty("NurseShiftTransferHistoryHdFromNurse")]
    public virtual Paramedic FromNurse { get; set; } = null!;

    [InverseProperty("Transfer")]
    public virtual ICollection<NurseShiftTransferHistoryDt> NurseShiftTransferHistoryDt { get; set; } = new List<NurseShiftTransferHistoryDt>();

    [ForeignKey("ServiceUnitId")]
    [InverseProperty("NurseShiftTransferHistoryHd")]
    public virtual DepartmentServiceUnit ServiceUnit { get; set; } = null!;

    [ForeignKey("ToNurseId")]
    [InverseProperty("NurseShiftTransferHistoryHdToNurse")]
    public virtual Paramedic ToNurse { get; set; } = null!;
}
