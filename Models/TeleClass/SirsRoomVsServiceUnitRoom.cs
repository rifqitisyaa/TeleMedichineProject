using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class SirsRoomVsServiceUnitRoom
{
    [StringLength(10)]
    [Unicode(false)]
    public string ID_TT { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string RoomCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
