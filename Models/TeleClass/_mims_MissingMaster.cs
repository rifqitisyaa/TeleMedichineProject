using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class _mims_MissingMaster
{
    [Key]
    public int MissingID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Master { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Name { get; set; }
}
