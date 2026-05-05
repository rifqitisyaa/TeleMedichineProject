using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ProjectMCUNo", "SequenceNo")]
public partial class PrintedArchiveMCUCorporate
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string ProjectMCUNo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    public byte[]? PDFFile { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReportType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReportTemplate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrintedDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [ForeignKey("SiteCode")]
    [InverseProperty("PrintedArchiveMCUCorporate")]
    public virtual Site SiteCodeNavigation { get; set; } = null!;
}
