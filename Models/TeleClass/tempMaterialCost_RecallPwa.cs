using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class tempMaterialCost_RecallPwa
{
    [Key]
    public int ItemID { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? MaterialCost { get; set; }
}
