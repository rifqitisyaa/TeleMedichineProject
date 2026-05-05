using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class SendToAutopackHistoryDt
{
    [Key]
    public long ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SendToAutopackNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int ItemID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AdministrationDateTime { get; set; }

    public int SignaQty { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string BaseUnit { get; set; } = null!;

    public bool IsSendToAutopack { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("BaseUnit")]
    [InverseProperty("SendToAutopackHistoryDt")]
    public virtual ItemUnit BaseUnitNavigation { get; set; } = null!;
}
