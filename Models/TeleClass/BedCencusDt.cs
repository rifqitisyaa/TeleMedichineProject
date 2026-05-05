using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class BedCencusDt
{
    [Column(TypeName = "datetime")]
    public DateTime? CencusDate { get; set; }

    public int? BedID { get; set; }

    public int? ServiceUnitID { get; set; }

    public int? RoomID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ClassCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? BedCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SiteCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCBedStatus { get; set; }

    public bool? IsTemporary { get; set; }

    public bool? IsActive { get; set; }
}
