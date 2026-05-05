using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class ReportNumberPrint
{
    [Key]
    public int Id { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string ReportID { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? NumberOfPrint { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDatetime { get; set; }
}
