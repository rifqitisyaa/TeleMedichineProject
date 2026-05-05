using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class PatientSurgeryStatus
{
    [Key]
    public int SurgeryStatusID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ReservationNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCTransferFrom { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCTransferTo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SurgeryStatusDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SurgeryRecordStartDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SurgeryRecordEndDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCPatientStatus { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GCStatusFrom { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("GCPatientStatus")]
    [InverseProperty("PatientSurgeryStatusGCPatientStatusNavigation")]
    public virtual sysGeneralCode GCPatientStatusNavigation { get; set; } = null!;

    [ForeignKey("GCStatusFrom")]
    [InverseProperty("PatientSurgeryStatusGCStatusFromNavigation")]
    public virtual sysGeneralCode GCStatusFromNavigation { get; set; } = null!;

    [ForeignKey("GCTransferFrom")]
    [InverseProperty("PatientSurgeryStatusGCTransferFromNavigation")]
    public virtual sysGeneralCode? GCTransferFromNavigation { get; set; }

    [ForeignKey("GCTransferTo")]
    [InverseProperty("PatientSurgeryStatusGCTransferToNavigation")]
    public virtual sysGeneralCode? GCTransferToNavigation { get; set; }

    [ForeignKey("ReservationNo")]
    [InverseProperty("PatientSurgeryStatus")]
    public virtual SurgeryReservation ReservationNoNavigation { get; set; } = null!;
}
