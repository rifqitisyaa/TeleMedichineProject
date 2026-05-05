using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class BedCencusHd
{
    public int? Tahun { get; set; }

    public int? Bulan { get; set; }

    public int? TotalBed { get; set; }
}
