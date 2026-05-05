using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class UangDudukFee
{
    [Key]
    public int FeeId { get; set; }

    public int ParamedicId { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal UangDudukAmount { get; set; }

    public int AttendanceId { get; set; }

    public int TotalFeeAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ProcessDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }
}
