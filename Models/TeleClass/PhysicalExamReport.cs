using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("RegistrationNo", "JobOrderNo", "SequenceNo")]
public partial class PhysicalExamReport
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [Key]
    public int SequenceNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [Unicode(false)]
    public string ItemName1 { get; set; } = null!;

    [Unicode(false)]
    public string? ItemName2 { get; set; }

    [Unicode(false)]
    public string? ResultValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Unit { get; set; }

    [Unicode(false)]
    public string? NormalValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Indicator { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdateDateTime { get; set; }
}
