using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class _LoadTestRegistration
{
    [Key]
    public int RecordID { get; set; }

    public int? RoomID { get; set; }

    public int? BedID { get; set; }

    public int? ServiceUnitID { get; set; }

    public bool? isUsed { get; set; }
}
