using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_BedTransfer
{
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
}
