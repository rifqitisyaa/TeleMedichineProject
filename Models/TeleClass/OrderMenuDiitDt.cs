using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("OrderID", "SequenceNo")]
public partial class OrderMenuDiitDt
{
    [Key]
    public int OrderID { get; set; }

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    public int SiklusId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string GCCategory { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string GroupCategory { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDateTime { get; set; }
}
