using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class WasteProcess
{
    [Key]
    public int ProcessID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProcessDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ProcessBy { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GCMachine { get; set; }

    public int? Duration { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FinishProcessDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DocumentNo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Result { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? TotalWeight { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GiveTo { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
