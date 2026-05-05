using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("IpAddress", "ReportId", "SequenceNo")]
public partial class IpAddressPrinter
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string IpAddress { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ReportId { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string PrinterPath { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string PrinterDisplayName { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Description { get; set; }

    public bool IsDefaultPrinter { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
