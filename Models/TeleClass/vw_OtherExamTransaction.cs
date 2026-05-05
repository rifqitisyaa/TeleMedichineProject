using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_OtherExamTransaction
{
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string MedicalNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string BusinessPartnerName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string JobOrderNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? TransactionNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime JobOrderDateTime { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string SequenceNo { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemName1 { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string ParamedicName { get; set; } = null!;

    [Column(TypeName = "numeric(10, 4)")]
    public decimal? QtyTaken { get; set; }

    [Column(TypeName = "numeric(19, 4)")]
    public decimal? Total { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaymentDateTime { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string IsPaid { get; set; } = null!;

    [Column(TypeName = "numeric(38, 4)")]
    public decimal? Outstanding { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ResultDateTime { get; set; }
}
