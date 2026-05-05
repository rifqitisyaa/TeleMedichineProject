using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class QueuingSlot
{
    [Key]
    public long Id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? WorkStationCode { get; set; }

    public int? ParamedicId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? WorkShiftCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SlotQueueNo { get; set; }

    public long? QueuingId { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
