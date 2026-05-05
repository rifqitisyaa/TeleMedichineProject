using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_AccountReceivable
{
    [StringLength(20)]
    [Unicode(false)]
    public string ARNo { get; set; } = null!;

    [Column("A/R Date")]
    public DateOnly A_R_Date { get; set; }

    [Column("A/R Due Date")]
    public DateOnly A_R_Due_Date { get; set; }

    [Column("Bill To Corporate")]
    [StringLength(100)]
    [Unicode(false)]
    public string Bill_To_Corporate { get; set; } = null!;

    [Column("Registration Number")]
    [StringLength(20)]
    [Unicode(false)]
    public string Registration_Number { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [Column("Nilai A/RA", TypeName = "numeric(18, 4)")]
    public decimal? Nilai_A_RA { get; set; }

    [Column("Discount Corporate", TypeName = "numeric(18, 4)")]
    public decimal? Discount_Corporate { get; set; }

    [Column("Total A/R", TypeName = "numeric(18, 4)")]
    public decimal? Total_A_R { get; set; }

    [Column("Outstanding A/R", TypeName = "numeric(19, 4)")]
    public decimal? Outstanding_A_R { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Status { get; set; } = null!;
}
