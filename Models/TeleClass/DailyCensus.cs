using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Keyless]
public partial class DailyCensus
{
    [Column(TypeName = "datetime")]
    public DateTime? CencusDate { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? RegistrationNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegistrationDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DischargeDateTime { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Class { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ServiceUnitID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? BedID { get; set; }
}
