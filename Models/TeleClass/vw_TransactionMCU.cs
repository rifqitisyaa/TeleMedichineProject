using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class vw_TransactionMCU
{
    [Column(TypeName = "datetime")]
    public DateTime RegistrationDateTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [Column("Paket MCU")]
    [StringLength(100)]
    [Unicode(false)]
    public string Paket_MCU { get; set; } = null!;

    [Column("Detail Tindakan MCU")]
    [StringLength(100)]
    [Unicode(false)]
    public string Detail_Tindakan_MCU { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ServiceUnitName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string BusinessPartnerName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TransactionDateTime { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string ParamedicName { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal Revenue { get; set; }
}
