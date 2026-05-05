using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class NameFound
{
    [StringLength(150)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NomorReferensi { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NoKtp { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MedicalNo { get; set; }
}
