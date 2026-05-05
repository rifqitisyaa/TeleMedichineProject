using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class sm_Paramedic
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string SmCode { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? SmName { get; set; }

    public int? ParamedicId { get; set; }
}
