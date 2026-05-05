using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AntreanPanggilJKN
{
    [Key]
    public int ParamedicID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WorkShiftCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? QueueNo { get; set; }
}
