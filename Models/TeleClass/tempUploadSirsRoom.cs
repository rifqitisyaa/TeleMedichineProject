using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tempUploadSirsRoom
{
    [StringLength(10)]
    [Unicode(false)]
    public string? RoomID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RoomCode { get; set; }

    [Unicode(false)]
    public string? RoomName { get; set; }

    [Column("ID TT SIRS")]
    [Unicode(false)]
    public string? ID_TT_SIRS { get; set; }

    public int? ID_TT { get; set; }
}
