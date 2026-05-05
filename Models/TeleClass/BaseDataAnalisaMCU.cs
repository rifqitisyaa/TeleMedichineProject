using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class BaseDataAnalisaMCU
{
    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Dob { get; set; }

    [Unicode(false)]
    public string? JenisKelamin { get; set; }

    [Unicode(false)]
    public string? Position { get; set; }

    [Column("MCU Mata")]
    [StringLength(1)]
    [Unicode(false)]
    public string? MCU_Mata { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? EKG { get; set; }

    [Column("MCU THT")]
    [StringLength(1)]
    [Unicode(false)]
    public string? MCU_THT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Thorax { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Treadmill { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Papsmear { get; set; }
}
