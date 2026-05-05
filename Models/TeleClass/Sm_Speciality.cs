using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Sm_Speciality
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string SmCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? SmName { get; set; }

    public int? ServiceUnitId { get; set; }
}
