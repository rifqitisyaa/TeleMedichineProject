using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("SctCode", "AnswerID")]
public partial class AnswerSct
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string AnswerID { get; set; } = null!;

    [Key]
    public int SctCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? SctName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LowValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LowCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? HighValue { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? HighCode { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
