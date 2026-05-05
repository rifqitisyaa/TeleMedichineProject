using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[PrimaryKey("ConsolidationID", "Referrerenceno")]
public partial class TransactionConsolidationReference
{
    [Key]
    public int ConsolidationID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string TransactionFrom { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationFrom { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationTo { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string Referrerenceno { get; set; } = null!;
}
