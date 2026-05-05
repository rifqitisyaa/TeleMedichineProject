using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class Promo
{
    [Key]
    public int ID { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? PictureFileName { get; set; }
}
