using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class tmpPiutangPribadiRudy
{
    [StringLength(20)]
    [Unicode(false)]
    public string ReferenceNo { get; set; } = null!;

    [StringLength(60)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal DebitAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal CreditAmount { get; set; }
}
