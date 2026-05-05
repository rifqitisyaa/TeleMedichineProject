using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class MimsImport
{
    [Key]
    public int ImportID { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Password { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MimsDbFileName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ImportDate { get; set; }

    [Unicode(false)]
    public string? LastStatus { get; set; }

    [Unicode(false)]
    public string? HistoryStatus { get; set; }

    public bool? IsImportSuccess { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MimsDBAddBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MimsDBAddDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
