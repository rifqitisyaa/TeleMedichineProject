using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("RoomID", "ClassCode", "BedCode", Name = "UNIQUE_IX_Bed", IsUnique = true)]
public partial class Bed
{
    [Key]
    public int BedID { get; set; }

    public int? ServiceUnitID { get; set; }

    public int RoomID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string BedCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReservationNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PhoneExtensionNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCBedStatus { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? GCTypeOfBed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDatetime { get; set; }

    public int? ItemIdAutomationCharges { get; set; }

    public int? ItemIdAutomationChargesNurse { get; set; }

    public bool? IsBooked { get; set; }

    public bool IsTemporary { get; set; }

    public bool? IsBPJSEnabled { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("Bed")]
    public virtual ICollection<BedCleaning> BedCleaning { get; set; } = new List<BedCleaning>();

    [InverseProperty("Bed")]
    public virtual ICollection<BedHistory> BedHistory { get; set; } = new List<BedHistory>();

    [InverseProperty("Bed")]
    public virtual ICollection<BedReservation> BedReservation { get; set; } = new List<BedReservation>();

    [InverseProperty("FromBed")]
    public virtual ICollection<BedTransfer> BedTransferFromBed { get; set; } = new List<BedTransfer>();

    [InverseProperty("ToBed")]
    public virtual ICollection<BedTransfer> BedTransferToBed { get; set; } = new List<BedTransfer>();

    [ForeignKey("ClassCode")]
    [InverseProperty("Bed")]
    public virtual Class ClassCodeNavigation { get; set; } = null!;

    [ForeignKey("GCBedStatus")]
    [InverseProperty("BedGCBedStatusNavigation")]
    public virtual sysGeneralCode GCBedStatusNavigation { get; set; } = null!;

    [ForeignKey("GCTypeOfBed")]
    [InverseProperty("BedGCTypeOfBedNavigation")]
    public virtual sysGeneralCode? GCTypeOfBedNavigation { get; set; }

    [ForeignKey("ItemIdAutomationCharges")]
    [InverseProperty("Bed")]
    public virtual Item? ItemIdAutomationChargesNavigation { get; set; }

    [InverseProperty("Bed")]
    public virtual ICollection<Registration> RegistrationBed { get; set; } = new List<Registration>();

    [InverseProperty("OriginalBed")]
    public virtual ICollection<Registration> RegistrationOriginalBed { get; set; } = new List<Registration>();

    [ForeignKey("RoomID")]
    [InverseProperty("Bed")]
    public virtual ServiceRoom Room { get; set; } = null!;

    [ForeignKey("ServiceUnitID")]
    [InverseProperty("Bed")]
    public virtual DepartmentServiceUnit? ServiceUnit { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("Bed")]
    public virtual Site? SiteCodeNavigation { get; set; }

    [InverseProperty("Bed")]
    public virtual ICollection<TransactionChargesHd> TransactionChargesHd { get; set; } = new List<TransactionChargesHd>();
}
