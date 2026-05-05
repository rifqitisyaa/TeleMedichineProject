using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class HistoryPosting
{
    [Key]
    public int HistoryID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PostingDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    public bool IsPosting { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PostingBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PostingDateTime { get; set; }

    public bool IsRollUp { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RollUpBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RollUpDateTime { get; set; }

    public bool IsProvitLos { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProvitLosBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProvitLosDateTime { get; set; }
}
