using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class StockInformationAccess
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string UserName { get; set; } = null!;

    public bool IsShowAmount { get; set; }

    public bool IsShowPrice { get; set; }

    public bool IsShowCost { get; set; }

    public bool IsShowJurnal { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
