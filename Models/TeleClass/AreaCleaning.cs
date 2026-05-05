using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class AreaCleaning
{
    [Key]
    public int CleaningID { get; set; }

    public int LocationID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TakenBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompletionDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? InspectBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InspectDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCResult { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Remark { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
