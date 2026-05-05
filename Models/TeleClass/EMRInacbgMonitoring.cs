using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

public partial class EMRInacbgMonitoring
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? InacbgAmount { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? TransactionAmount { get; set; }

    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Unicode(false)]
    public string? LastUpdatedDateTime { get; set; }
}
