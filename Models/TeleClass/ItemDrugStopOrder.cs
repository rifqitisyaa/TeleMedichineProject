using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ItemDrugStopOrder
{
    [Key]
    public int ItemID { get; set; }

    public int StopOrderQty { get; set; }

    public int? BusinessPartnerID { get; set; }

    [Unicode(false)]
    public string? Retriksi { get; set; }

    public int? QtyRetriksi { get; set; }

    public bool? IsByDays { get; set; }

    public bool? IsByQty { get; set; }

    public bool? IsByEpisode { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
