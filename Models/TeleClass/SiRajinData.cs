using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class SiRajinData
{
    public int? id { get; set; }

    public int? id_perekam_medis { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? tipe_pasien { get; set; }

    public int? id_pasien { get; set; }

    public int? id_poliklinik { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? user { get; set; }
}
