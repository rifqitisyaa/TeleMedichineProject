using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class BedTransfer
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string TransferNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TransferDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public int FromServiceUnitID { get; set; }

    public int FromRoomID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string FromClassCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string FromChargeClassCode { get; set; } = null!;

    public int FromBedID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string FromSpecialtyCode { get; set; } = null!;

    public int ToServiceUnitID { get; set; }

    public int ToRoomID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ToClassCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ToChargeClassCode { get; set; } = null!;

    public int ToBedID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ToSpecialtyCode { get; set; } = null!;

    public bool IsConfirmed { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("FromBedID")]
    [InverseProperty("BedTransferFromBed")]
    public virtual Bed FromBed { get; set; } = null!;

    [ForeignKey("FromChargeClassCode")]
    [InverseProperty("BedTransferFromChargeClassCodeNavigation")]
    public virtual Class FromChargeClassCodeNavigation { get; set; } = null!;

    [ForeignKey("FromClassCode")]
    [InverseProperty("BedTransferFromClassCodeNavigation")]
    public virtual Class FromClassCodeNavigation { get; set; } = null!;

    [ForeignKey("FromRoomID")]
    [InverseProperty("BedTransferFromRoom")]
    public virtual ServiceRoom FromRoom { get; set; } = null!;

    [ForeignKey("FromServiceUnitID")]
    [InverseProperty("BedTransferFromServiceUnit")]
    public virtual DepartmentServiceUnit FromServiceUnit { get; set; } = null!;

    [ForeignKey("FromSpecialtyCode")]
    [InverseProperty("BedTransferFromSpecialtyCodeNavigation")]
    public virtual Specialty FromSpecialtyCodeNavigation { get; set; } = null!;

    [ForeignKey("RegistrationNo")]
    [InverseProperty("BedTransfer")]
    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    [ForeignKey("SiteCode")]
    [InverseProperty("BedTransfer")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;

    [ForeignKey("ToBedID")]
    [InverseProperty("BedTransferToBed")]
    public virtual Bed ToBed { get; set; } = null!;

    [ForeignKey("ToChargeClassCode")]
    [InverseProperty("BedTransferToChargeClassCodeNavigation")]
    public virtual Class ToChargeClassCodeNavigation { get; set; } = null!;

    [ForeignKey("ToClassCode")]
    [InverseProperty("BedTransferToClassCodeNavigation")]
    public virtual Class ToClassCodeNavigation { get; set; } = null!;

    [ForeignKey("ToRoomID")]
    [InverseProperty("BedTransferToRoom")]
    public virtual ServiceRoom ToRoom { get; set; } = null!;

    [ForeignKey("ToServiceUnitID")]
    [InverseProperty("BedTransferToServiceUnit")]
    public virtual DepartmentServiceUnit ToServiceUnit { get; set; } = null!;

    [ForeignKey("ToSpecialtyCode")]
    [InverseProperty("BedTransferToSpecialtyCodeNavigation")]
    public virtual Specialty ToSpecialtyCodeNavigation { get; set; } = null!;

    [ForeignKey("TransactionCode")]
    [InverseProperty("BedTransfer")]
    public virtual sysTransactionCode TransactionCodeNavigation { get; set; } = null!;
}
