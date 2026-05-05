using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_MasterBed
{
    [StringLength(10)]
    [Unicode(false)]
    public string BedCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ServiceUnitCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RoomCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ClassCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReservationNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PhoneExtensionNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BedStatus { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TypeOfBed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDatetime { get; set; }

    public bool? IsBooked { get; set; }

    public bool IsTemporary { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
