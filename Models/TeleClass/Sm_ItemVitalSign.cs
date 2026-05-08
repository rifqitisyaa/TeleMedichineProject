using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Sm_ItemVitalSign
{
    [Key]
    public int id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SmCodeItem { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SphairaCodeItem { get; set; }
}
