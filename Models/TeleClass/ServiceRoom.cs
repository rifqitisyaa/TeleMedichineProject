using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ServiceRoom
{
    [Key]
    public int RoomID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string RoomCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string RoomName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? IP { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Room")]
    public virtual ICollection<Bed> Bed { get; set; } = new List<Bed>();

    [InverseProperty("FromRoom")]
    public virtual ICollection<BedTransfer> BedTransferFromRoom { get; set; } = new List<BedTransfer>();

    [InverseProperty("ToRoom")]
    public virtual ICollection<BedTransfer> BedTransferToRoom { get; set; } = new List<BedTransfer>();

    [InverseProperty("Room")]
    public virtual ICollection<CensusHistory> CensusHistory { get; set; } = new List<CensusHistory>();

    [InverseProperty("Room")]
    public virtual ICollection<PatientAttendance> PatientAttendance { get; set; } = new List<PatientAttendance>();

    [InverseProperty("Room")]
    public virtual ICollection<PrescriptionPayment> PrescriptionPayment { get; set; } = new List<PrescriptionPayment>();

    [InverseProperty("Room")]
    public virtual ICollection<Registration> Registration { get; set; } = new List<Registration>();

    [InverseProperty("Room")]
    public virtual ICollection<ServiceUnitRoom> ServiceUnitRoom { get; set; } = new List<ServiceUnitRoom>();

    [InverseProperty("Room")]
    public virtual ICollection<TransactionChargesHd> TransactionChargesHd { get; set; } = new List<TransactionChargesHd>();

    [InverseProperty("Room")]
    public virtual ICollection<WorkStation> WorkStation { get; set; } = new List<WorkStation>();
}
