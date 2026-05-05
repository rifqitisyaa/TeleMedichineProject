using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class McuDateMaster
{
    [Key]
    public int id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? dateString { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public int? mcuTotal { get; set; }
}
