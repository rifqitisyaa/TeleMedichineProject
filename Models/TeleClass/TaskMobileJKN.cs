using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("KodeBookingNo", "TaskID")]
public partial class TaskMobileJKN
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string KodeBookingNo { get; set; } = null!;

    [Key]
    public int TaskID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Waktu { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
